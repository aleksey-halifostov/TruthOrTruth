namespace TruthOrTruth.Players
{
    public struct Player
    {
        private readonly int _id;
        private readonly string _name;

        public int Id => _id;
        public string Name => _name;

        public Player(int id, string name)
        {
            if (id < 0)
                throw new System.ArgumentOutOfRangeException(nameof(id));

            if (name == null || name == string.Empty)
                throw new System.ArgumentException(nameof(name));

            _id = id;
            _name = name;
        }
    }
}