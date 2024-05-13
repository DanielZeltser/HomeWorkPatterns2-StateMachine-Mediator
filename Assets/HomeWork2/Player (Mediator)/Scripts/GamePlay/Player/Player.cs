using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    [RequireComponent(typeof(PlayerCollider))]

    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private PlayerConfig _config;
        [SerializeField] private PlayerStartPoint _startPoint;

        private PlayerCollider _collider;
        private PlayerHealth _health;
        private PlayerLevel _level;

        public PlayerHealth Health => _health;
        public PlayerLevel Level => _level;

        public void Initialize()
        {
            _health = new PlayerHealth(_config.Health);
            _level = new PlayerLevel(_config.Level);

            _collider = GetComponent<PlayerCollider>();
            _collider.Initialize(_health, _level);

            ResetPosition();
        }

        public void ResetPosition()
        {
            transform.position = _startPoint.Position;
        }

        public void ResetProperties()
        {
            Health.Reset();
            Level.Reset();
        }
    }
}
