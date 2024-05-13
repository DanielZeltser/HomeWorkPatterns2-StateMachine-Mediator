using System;
using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]  

    public sealed class PlayerCollider : MonoBehaviour
    {
        private PlayerHealth _playerHealth;
        private PlayerLevel _playerLevel;

        public event Action UpdatedPlayerHealthView;
        public event Action UpdatedPlayerLevelView;

        public void Initialize(PlayerHealth playerHealth, PlayerLevel playerLevel)
        {
            _playerHealth = playerHealth;
            _playerLevel = playerLevel;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IAttackable enemy))
            {
                _playerHealth.TakeDamage(enemy.AttackDamage);
                UpdatedPlayerHealthView?.Invoke();
            }

            if (other.TryGetComponent(out LevelUpPoint levelUpPoint))
            {
                _playerLevel.LevelUp();
                UpdatedPlayerLevelView?.Invoke();
            }
        }
    }
}
