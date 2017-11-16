namespace Ascend.Example.UI
{
    public interface IUi
    {
        char ReadKey(char testOveride);
        void WriteLine(string format, params object[] arg);
        void Write(string format);
        string ReadLine(string testOveride);

        void Clear();

    }
}
