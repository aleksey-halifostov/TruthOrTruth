using TMPro;
using UnityEngine;
using TruthOrTruth.Players;
using UnityEngine.UI;

namespace TruthOrTruth.PlayerRegistration
{
    public class RegistrationController : MonoBehaviour
    {
        private PlayerRegistrator _registrator = new PlayerRegistrator();

        [SerializeField] private Transform _container;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private TMP_InputField _newPlayer;

        private void SetupPrefab(GameObject prefab, Player player)
        {
            prefab.GetComponentInChildren<TextMeshProUGUI>().text = player.Name;
            prefab.GetComponentInChildren<Button>().onClick.AddListener(() => UnregisterPlayer(prefab, player));
        }

        public Player[] GetPlayers()
        {
            return _registrator.GetPlayers();
        }

        public void RegisterPlayer()
        {
            if (_newPlayer.text == string.Empty)
                return;

            Player player = _registrator.Register(_newPlayer.text);
            GameObject newPlayer = Instantiate(_prefab);
            newPlayer.transform.SetParent(_container, false);
            SetupPrefab(newPlayer, player);
            _newPlayer.text = string.Empty;
        }

        public void UnregisterPlayer(GameObject prefab, Player player)
        {
            Destroy(prefab);
            _registrator.Unregister(player);
        }
    }
}