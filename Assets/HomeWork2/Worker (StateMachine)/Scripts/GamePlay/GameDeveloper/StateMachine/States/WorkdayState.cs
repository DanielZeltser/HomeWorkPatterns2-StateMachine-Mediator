using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public class WorkdayState : IState
    {
        protected readonly GameDeveloper GameDeveloper;
        protected readonly StateSwitcher StateSwitcher;

        public WorkdayState(GameDeveloper gameDeveloper, StateSwitcher stateSwitcher)
        {
            GameDeveloper = gameDeveloper;
            StateSwitcher = stateSwitcher;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
        }

        public virtual void Update() { }

        public virtual void Exit() { }
    }
}
