using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public sealed class GameDeveloperStateMachine : StateSwitcher
    {
        private readonly List<IState> _states;
        private IState _currentState;

        public GameDeveloperStateMachine(GameDeveloper gameDeveloper, Vector3 officePosition, Vector3 homePosition) 
        {
            _states = new List<IState>()
            {
                 new MovingToOfficeState(gameDeveloper, this, officePosition),
                 new GameDevelopingState(gameDeveloper, this),
                 new RunningToHomeState(gameDeveloper, this, homePosition),
                 new WatchingDemonSlayerState(gameDeveloper, this),
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public override void SwitchState<T>()
        {
            IState state = _states.FirstOrDefault(s => s is T);

            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();

    }
}
