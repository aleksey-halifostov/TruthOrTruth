using System;
using System.Collections.Generic;
using TruthOrTruth.Players;

namespace TruthOrTruth.TextSource
{
    public class PlayersTextSource : ITextSource
    {
        private Player[] _players;
        private List<Player> _playersQueue;
        private Random _random = new Random();

        private void FillQueue()
        {
            _playersQueue = new List<Player>(_players);
        }

        public PlayersTextSource(Player[] players)
        {
            if (players == null)
            {
                throw new ArgumentNullException(nameof(players));
            }

            _players = players;
            FillQueue();
        }

        public string GetText()
        {
            if (_playersQueue.Count == 0)
                FillQueue();

            int index = _random.Next(0, _playersQueue.Count);
            string name = _playersQueue[index].Name;
            _playersQueue.RemoveAt(index);
            return name;
        }
    }
}