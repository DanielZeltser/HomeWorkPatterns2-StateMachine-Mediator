using System;
using System.Threading.Tasks;

namespace HomeWork2.Worker.GamePlay
{
    public abstract class StateSwitcher 
    {
        public abstract void SwitchState<T>() where T : IState;

        public async Task SwitchStateInDelay<T>(float seconds) where T : IState
        {
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            SwitchState<T>();
        }
    }
}
