namespace UnityStudy.DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
