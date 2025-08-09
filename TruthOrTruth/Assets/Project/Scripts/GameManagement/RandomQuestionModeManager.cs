using TruthOrTruth.TextSource;

namespace TruthOrTruth.GameManagement
{
    public class RandomQuestionModeManager : ModeManager
    {
        public override void TransferControl()
        {
            _injector.UIManager.HideMainMenu();
            _injector.UIManager.SetupButtons(SimpleOnMainMenuButtonClicked);
            ITextSource textSource = new QuestionTextSource();
            _injector.CardController.SetTextSource(textSource);
            SimpleOnGameStarted();
        }
    }
}