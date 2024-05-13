using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public  class WatchingDemonSlayerState : WorkdayState
    {
        private float TimeWatchingDemonSlayer => GameDeveloper.Config.WatchingDemonSlayerStateConfig.TimeWatching;

        public WatchingDemonSlayerState(GameDeveloper gameDeveloper, StateSwitcher stateSwitcher) : base(gameDeveloper, stateSwitcher)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Debug.Log("Wow, uzui is so attractive!");

            _ = StateSwitcher.SwitchStateInDelay<MovingToOfficeState>(TimeWatchingDemonSlayer);
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("oh shit it's 9 o'clock of morning, I need to go to office");
        }
    }
}
