using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class Enemy : MonoBehaviour, IAttackable
    {
        [field: SerializeField, Range(0, 10)] public int AttackDamage { get; private set; } 

    }
}
