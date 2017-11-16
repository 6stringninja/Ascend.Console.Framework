namespace Ascend.Example.Screen.Menu
{
    public abstract class Menu : IMenu
    {
        public char ExecuteCharacter { get; set; }
        public string DisplayMessage { get; set; }
        public bool Display { get; set; }
        public bool CaseSensitiveExeChar { get; set; }
        public void Print() => Application.AppBase.UI.WriteLine("'{0}' {1}'",  ExecuteCharacter,  DisplayMessage);
    }
}