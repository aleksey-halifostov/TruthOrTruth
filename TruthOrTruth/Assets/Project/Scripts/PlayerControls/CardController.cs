using System;
using UnityEngine;
using DG.Tweening;
using TMPro;
using TruthOrTruth.TextSource;

namespace TruthOrTruth.PlayerControls 
{
    public class CardController : MonoBehaviour
    {
        private bool _isFaced = false;
        private ITextSource _textSource;
        private Quaternion _simpleRotation = Quaternion.Euler(0, 0, 0);
        private Quaternion _facedRotation = Quaternion.Euler(0, 180, 0);
        private float _rotationTime = .5f;

        [SerializeField] private Transform _card;
        [SerializeField] private TextMeshProUGUI _cardText;

        public static event Action OnCardUpdating;

        public void SetTextSource(ITextSource textSource)
        {
            if (textSource == null)
                throw new System.ArgumentNullException(nameof(textSource));

            _textSource = textSource;
        }

        public void ResetCardRotation()
        {
            _card.rotation = _simpleRotation;
        }

        public void SwapCard()
        {
            if (!_isFaced)
            {
                _card.DORotateQuaternion(_facedRotation, _rotationTime);
                _cardText.text = _textSource.GetText();
            }
            else
            {
                _card.DORotateQuaternion(_simpleRotation, _rotationTime);
                OnCardUpdating?.Invoke();
            }

            _isFaced = !_isFaced;
        }
    }
}
