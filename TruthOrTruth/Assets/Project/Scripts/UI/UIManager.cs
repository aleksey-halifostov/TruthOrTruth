using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace TruthOrTruth.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _registrationMenu;
        [SerializeField] private Button _registrationStartButton;
        [SerializeField] private Button _registrationBackButton;
        [SerializeField] private Button _mainMenuButton;
 
        public void HideMainMenu()
        {
            _mainMenu.SetActive(false);
        }

        public void ShowMainMenu()
        {
            _mainMenu.SetActive(true);
            HideRegistration();
        }

        public void ShowRegistration()
        {
            HideMainMenu();
            _registrationMenu.SetActive(true);
        }

        public void HideRegistration()
        {
            _registrationMenu.SetActive(false);
        }

        public void SetupButtons(UnityAction onMainMenuButtonClicked)
        {
            _mainMenuButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.AddListener(onMainMenuButtonClicked);
        }

        public void SetupButtons(UnityAction onMainMenuButtonClicked, UnityAction onRegistrationStartButtonClicked, UnityAction onRegistrationBackButtonClicked)
        {
            SetupButtons(onMainMenuButtonClicked);

            _registrationStartButton.onClick.RemoveAllListeners();
            _registrationStartButton.onClick.AddListener(onRegistrationStartButtonClicked);

            _registrationBackButton.onClick.RemoveAllListeners();
            _registrationBackButton.onClick.AddListener(onRegistrationBackButtonClicked);
        }
    }
}
