using TruthOrTruth.Players;
using TruthOrTruth.TextSource;

namespace TruthOrTruth.GameManagement
{
    public class RandomPlayerModeManager : ModeManager
    {
        public override void TransferControl()
        {
            _injector.UIManager.ShowRegistration();
            _injector.RegistrationStartButton.onClick.RemoveAllListeners();
            _injector.RegistrationStartButton.onClick.AddListener(
                () =>
                {
                    Player[] players = _injector.RegistrationController.GetPlayers();
                    if (players != null && players.Length > 1)
                    {
                        _injector.UIManager.HideRegistration();
                        _injector.Swapper.SetTextSource(new PlayersTextSource(players));
                        _injector.Card.SetActive(true);
                    }
                }
                );
        }
    }
}