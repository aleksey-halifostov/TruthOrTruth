using TMPro;
using TruthOrTruth.PlayerControls;
using TruthOrTruth.PlayerRegistration;
using TruthOrTruth.UI;
using UnityEngine;
using UnityEngine.UI;

namespace TruthOrTruth.GameManagement
{
    public class Injector : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _additionalText;
        [SerializeField] private Button _registrationStartButton;
        [SerializeField] private UIManager _uiManager;
        [SerializeField] private CardSwapper _swapper;
        [SerializeField] private GameObject _card;
        [SerializeField] private RegistrationController _registrationController;

        public TextMeshProUGUI AdditionalText => _additionalText;
        public Button RegistrationStartButton => _registrationStartButton;
        public UIManager UIManager => _uiManager;
        public CardSwapper Swapper => _swapper;
        public GameObject Card => _card;
        public RegistrationController RegistrationController => _registrationController;
    }
}