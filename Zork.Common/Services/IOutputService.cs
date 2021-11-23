namespace Zork
{
    public interface IOutputService
    {
        void Write(string message);

        void WriteLine(string message);

        void Clear();
    }
}
