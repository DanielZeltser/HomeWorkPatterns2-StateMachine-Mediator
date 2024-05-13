using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public sealed class MovingToOfficeState : WorkdayState
    {
        private readonly Vector3 _officePosition;

        private float MoveSpeed => GameDeveloper.Config.MovingToOfficeConfig.MoveSpeed;

        public MovingToOfficeState(GameDeveloper gameDeveloper, StateSwitcher stateSwitcher, Vector3 officePosition) : base(gameDeveloper, stateSwitcher)
        {
            _officePosition = officePosition;
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();

            GameDeveloper.Movement.MoveTo(_officePosition, MoveSpeed);

            if (GameDeveloper.IsInOffice)
                StateSwitcher.SwitchState<GameDevelopingState>();
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("Okay, let's start to develop next top-cart hit");
        }
    }
}
