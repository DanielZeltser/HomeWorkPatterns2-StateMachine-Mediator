using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{

    public sealed class Player : MonoBehaviour , IDamageable , ILevelable
    {
        [SerializeField] private PlayerConfig _config;
        [SerializeField] private PlayerStartPoint _startPoint;

        public PlayerHealth Health { get; private set; }
        public PlayerLevel Level { get; private set; }

        public void Initialize()
        {
            Health = new PlayerHealth(_config.Health);
            Level = new PlayerLevel(_config.Level);

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
