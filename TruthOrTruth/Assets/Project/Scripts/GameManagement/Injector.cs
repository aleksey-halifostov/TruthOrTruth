using TMPro;
using TruthOrTruth.PlayerControls;
using TruthOrTruth.PlayerRegistration;
using TruthOrTruth.UI;
using UnityEngine;

namespace TruthOrTruth.GameManagement
{
    public class Injector : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _additionalText;
        [SerializeField] private UIManager _uiManager;
        [SerializeField] private CardController _cardController;
        [SerializeField] private GameObject _card;
        [SerializeField] private RegistrationController _registrationController;
        [SerializeField] private GameObject _mainMenuButton;

        public TextMeshProUGUI AdditionalText => _additionalText;
        public UIManager UIManager => _uiManager;
        public CardController CardController => _cardController;
        public GameObject Card => _card;
        public RegistrationController RegistrationController => _registrationController;
        public GameObject MainMenuButton => _mainMenuButton;
    }
}