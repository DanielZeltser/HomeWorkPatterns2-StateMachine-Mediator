using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public sealed class GameDevelopingState : WorkdayState
    {
        private float TimeGameDeveloping => GameDeveloper.Config.GameDevelopingStateConfig.TimeDeveloping;

        public GameDevelopingState(GameDeveloper gameDeveloper, StateSwitcher stateSwitcher) : base(gameDeveloper, stateSwitcher)
        {
        }

        public override void Enter() 
        {
            base.Enter();

            Debug.Log("I so love my job!");

            _ = StateSwitcher.SwitchStateInDelay<RunningToHomeState>(TimeGameDeveloping);
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("I'm so tired , I need to rest in my home right now");
        }
    }
}
