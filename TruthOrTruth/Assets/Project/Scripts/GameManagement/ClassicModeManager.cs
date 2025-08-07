using TruthOrTruth.Players;
using TruthOrTruth.TextSource;

namespace TruthOrTruth.GameManagement
{
    public class ClassicModeManager : ModeManager
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
                        gameObject.AddComponent<Synchronizer>().Init(_injector.AdditionalText, new PlayersTextSource(players));
                        _injector.Swapper.SetTextSource(new QuestionTextSource());
                        _injector.Card.SetActive(true);
                    }
                }
            );
        }
    }
}