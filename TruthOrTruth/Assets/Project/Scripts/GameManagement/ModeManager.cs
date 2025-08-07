using UnityEngine;

namespace TruthOrTruth.GameManagement
{
    public class ModeManager : MonoBehaviour, IGameManager
    {
        protected Injector _injector;

        public void Init(Injector injector)
        {
            if (injector == null)
                throw new System.ArgumentNullException(nameof(injector));

            _injector = injector;
        }

        public virtual void TransferControl()
        {
            
        }
    }
}