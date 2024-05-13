
namespace HomeWork2.Worker.GamePlay
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}