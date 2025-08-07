using TMPro;
using TruthOrTruth.PlayerControls;
using TruthOrTruth.TextSource;
using UnityEngine;

namespace TruthOrTruth.GameManagement
{
    public class Synchronizer : MonoBehaviour
    {
        private TextMeshProUGUI _text;
        private ITextSource _source;

        private void OnEnable()
        {
            CardSwapper.OnCardUpdating += UpdateAdditionalText;
        }

        private void OnDisable()
        {
            CardSwapper.OnCardUpdating -= UpdateAdditionalText;
        }

        private void UpdateAdditionalText()
        {
            _text.text = _source.GetText();
        }

        public void Init(TextMeshProUGUI text, ITextSource source)
        {
            if (text == null)
                throw new System.ArgumentNullException(nameof(text));

            if (source == null)
                throw new System.ArgumentNullException(nameof(source));

            _text = text;
            _source = source;
            _text.gameObject.SetActive(true);

            UpdateAdditionalText();
        }
    }
}