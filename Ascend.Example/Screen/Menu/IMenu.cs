namespace Ascend.Example.Screen.Menu
{
    public interface IMenu
    {
        char ExecuteCharacter { get; set; }
        string DisplayMessage { get; set; }
        bool Display { get; set; }
        bool CaseSensitiveExeChar { get; set; }
        void Print();

    }
}

