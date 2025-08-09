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
            if (gameObject.TryGetComponent<IModeManager>(out IModeManager component))
                Destroy((MonoBehaviour)component);

            IModeManager manager = gameObject.AddComponent(GetManagerType((GameMode)mode)).GetComponent<IModeManager>();
            manager.Init(_injector);
            manager.TransferControl();
        }
    }
}
