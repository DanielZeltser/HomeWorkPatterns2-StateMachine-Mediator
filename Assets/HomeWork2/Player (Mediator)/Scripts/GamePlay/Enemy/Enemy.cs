using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class Enemy : MonoBehaviour
    {
        [field: SerializeField, Range(0, 10)] public int AttackDamage { get; private set; }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IDamageable player))
                player.Health.TakeDamage(AttackDamage);
        }
    }
}
