using Ascend.Example.Screen;

namespace Ascend.Example.Application
{
    public interface IApp
    {
        IScreens Screens { get; set; }
        void Run();

    }
}
