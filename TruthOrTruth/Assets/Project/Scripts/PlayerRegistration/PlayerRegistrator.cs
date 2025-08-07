using System.Collections.Generic;
using TMPro;
using TruthOrTruth.Players;
using UnityEngine;

namespace TruthOrTruth.PlayerRegistration
{
    public class PlayerRegistrator
    {
        private List<Player> _players = new List<Player>();
        private int _playersCounter = 0;

        public Player Register(string name)
        {
            Player player = new Player(_playersCounter++, name);
            _players.Add(player);

            return player;
        }

        public void Unregister(Player player)
        {
            _players.Remove(player);
        }

        public Player[] GetPlayers()
        {
            return _players.ToArray();
        }
    }
}
