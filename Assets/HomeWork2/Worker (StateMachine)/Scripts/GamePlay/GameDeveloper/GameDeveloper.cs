using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    [RequireComponent(typeof(GameDeveloperCollider))]

    public sealed class GameDeveloper : MonoBehaviour
    {
        [SerializeField] private Home _home;
        [SerializeField] private Office _office;

        private GameDeveloperStateMachine _stateMachine;
        private GameDeveloperCollider _collider;

        [field: SerializeField] public GameDeveloperConfig Config { get; private set; }
        public bool IsAtHome => _collider.IsTouchesHomeCollider;
        public bool IsInOffice => _collider.IsTouchesOfficeCollider;
        public GameDeveloperMovement Movement { get; private set; }

        public void Initialize()
        {
            Movement = new GameDeveloperMovement(transform);
            _stateMachine = new GameDeveloperStateMachine(this, _office.Position, _home.Position);

            _collider = GetComponent<GameDeveloperCollider>();
        }

        private void Update()
        {
            _stateMachine.Update();
        }
    }
}
