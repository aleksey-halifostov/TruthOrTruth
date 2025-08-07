using System;
using UnityEngine;

namespace TruthOrTruth.GameManagement
{
    [RequireComponent(typeof(Injector))]
    public class Bootstrap : MonoBehaviour
    {
        private Injector _injector;

        private void Awake()
        {
            _injector = GetComponent<Injector>();
        }

        private Type GetManagerType(GameMode mode)
        {
            switch (mode)
            {
                case GameMode.Classic:
                    return typeof(ClassicModeManager);
                case GameMode.RandomPlayer:
                    return typeof(RandomPlayerModeManager);
                case GameMode.RandomQuestion:
                    return typeof(RandomQuestionModeManager);
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode));
            }
        }

        public void SetMode(int mode)
        {
            if (gameObject.TryGetComponent<IGameManager>(out IGameManager component))
                Destroy((MonoBehaviour)component);

            IGameManager manager = gameObject.AddComponent(GetManagerType((GameMode)mode)).GetComponent<IGameManager>();
            manager.Init(_injector);
            manager.TransferControl();
        }
    }
}
