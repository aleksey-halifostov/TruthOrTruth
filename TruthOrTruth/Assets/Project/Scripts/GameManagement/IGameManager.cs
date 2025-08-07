namespace TruthOrTruth.GameManagement
{
    public interface IGameManager
    {
        public void Init(Injector injector);
        public void TransferControl();
    }
}