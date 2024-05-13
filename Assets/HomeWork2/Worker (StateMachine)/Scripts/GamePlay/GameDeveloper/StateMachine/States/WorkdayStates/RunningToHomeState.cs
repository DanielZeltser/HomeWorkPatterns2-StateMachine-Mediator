using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public sealed class RunningToHomeState : WorkdayState
    {
        private readonly Vector3 _homePosition;

        private float MoveSpeed => GameDeveloper.Config.RunningToHomeConfig.MoveSpeed;

        public RunningToHomeState(GameDeveloper gameDeveloper, StateSwitcher stateSwitcher, Vector3 homePosition) : base(gameDeveloper, stateSwitcher)
        {
            _homePosition = homePosition;
        }
       
        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();

            GameDeveloper.Movement.MoveTo(_homePosition, MoveSpeed);

            if (GameDeveloper.IsAtHome)
                StateSwitcher.SwitchState<WatchingDemonSlayerState>();
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("Finally I am at home, I'm going rewatch Demon Slayer season 2");
        }
    }
}
