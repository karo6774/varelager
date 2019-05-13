namespace Varelager
{
    public interface IPage
    {
        string Label { get; }
        void Execute();
    }
}