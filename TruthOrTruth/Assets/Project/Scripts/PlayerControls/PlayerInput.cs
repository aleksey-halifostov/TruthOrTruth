using UnityEngine;

namespace TruthOrTruth.PlayerControls
{
    [RequireComponent(typeof(CardController))]
    public class PlayerInput : MonoBehaviour
    {
        private GameActions _input;
        private CardController _swapper;

        private void Awake()
        {
            _input = new GameActions();
            _swapper = GetComponent<CardController>();
        }

        private void OnEnable()
        {
            _input.Enable();
            _input.Toucher.Touch.performed += context => ProcessInput(context.ReadValue<Vector2>());
        }

        private void OnDisable()
        {
            _input.Toucher.Touch.performed -= context => ProcessInput(context.ReadValue<Vector2>());
            _input.Disable();
        }

        private void ProcessInput(Vector2 touchPosition)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(touchPosition), out RaycastHit hitInfo, 1) && hitInfo.collider.GetComponent<Card.Card>() != null)
            {
                _swapper.SwapCard();
            }
        }
    }
}