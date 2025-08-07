using UnityEngine;

namespace TruthOrTruth.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _registrationMenu;
 
        public void HideMainMenu()
        {
            _mainMenu.SetActive(false);
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
    }
}
