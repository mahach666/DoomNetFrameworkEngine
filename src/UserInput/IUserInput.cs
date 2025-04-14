using DoomNetFrameworkEngine.DoomEntity.Game;

namespace DoomNetFrameworkEngine.UserInput
{
    public interface IUserInput
    {
        void BuildTicCmd(TicCmd cmd);
        void Reset();
        void GrabMouse();
        void ReleaseMouse();

        public int MaxMouseSensitivity { get; }
        public int MouseSensitivity { get; set; }
    }
}
