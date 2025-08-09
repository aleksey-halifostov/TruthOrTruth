using TruthOrTruth.Players;
using TruthOrTruth.TextSource;

namespace TruthOrTruth.GameManagement
{
    public class ClassicModeManager : ModeManager
    {
        private void OnRegistrationStartButtonClicked()
        {
            Player[] players = _injector.RegistrationController.GetPlayers();

            if (players == null || players.Length <= 1)
                return;

            SimpleOnGameStarted();
            _injector.UIManager.HideRegistration();
            _injector.CardController.SetTextSource(new QuestionTextSource());
            gameObject.AddComponent<Synchronizer>().Init(_injector.AdditionalText, new PlayersTextSource(players));
        }

        private void OnMainMenuButtonClicked()
        {
            Destroy(GetComponent<Synchronizer>());
            SimpleOnMainMenuButtonClicked();
        }

        public override void TransferControl()
        {
            _injector.UIManager.ShowRegistration();
            _injector.UIManager.SetupButtons(OnMainMenuButtonClicked, OnRegistrationStartButtonClicked, SimpleOnRegistrationBackButtonClicked);
        }
    }
}