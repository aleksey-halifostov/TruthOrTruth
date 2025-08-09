using TruthOrTruth.Players;
using TruthOrTruth.TextSource;
using TruthOrTruth.UI;

namespace TruthOrTruth.GameManagement
{
    public class RandomPlayerModeManager : ModeManager
    {
        private void OnRegistrationStartButtonClicked()
        {
            Player[] players = _injector.RegistrationController.GetPlayers();

            if (players == null || players.Length <= 1)
                return;

            SimpleOnGameStarted();
            _injector.UIManager.HideRegistration();
            _injector.CardController.SetTextSource(new PlayersTextSource(players));
        }

        public override void TransferControl()
        {
            _injector.UIManager.ShowRegistration();
            _injector.UIManager.SetupButtons(SimpleOnMainMenuButtonClicked, OnRegistrationStartButtonClicked, SimpleOnRegistrationBackButtonClicked);
        }
    }
}