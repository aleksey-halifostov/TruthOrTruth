using UnityEngine;

namespace TruthOrTruth.GameManagement
{
    public class ModeManager : MonoBehaviour, IModeManager
    {
        protected Injector _injector;

        protected void SimpleOnMainMenuButtonClicked()
        {
            _injector.UIManager.ShowMainMenu();
            _injector.Card.SetActive(false);
            _injector.CardController.ResetCardRotation();
            _injector.MainMenuButton.SetActive(false);
            Destroy(this);
        }

        protected void SimpleOnGameStarted()
        {
            _injector.Card.SetActive(true);
            _injector.MainMenuButton.SetActive(true);
        }

        protected void SimpleOnRegistrationBackButtonClicked()
        {
            _injector.UIManager.ShowMainMenu();
            Destroy(this);
        }

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