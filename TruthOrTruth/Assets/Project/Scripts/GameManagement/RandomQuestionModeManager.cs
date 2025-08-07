using TruthOrTruth.TextSource;

namespace TruthOrTruth.GameManagement
{
    public class RandomQuestionModeManager : ModeManager
    {
        public override void TransferControl()
        {
            _injector.UIManager.HideMainMenu();
            _injector.Swapper.SetTextSource(new QuestionTextSource());
            _injector.Card.SetActive(true);
        }
    }
}