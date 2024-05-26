using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class LevelUpPoint : MonoBehaviour
    {
        [field: SerializeField, Range(0, 2)] private int _levelUpValue;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ILevelable player))
                player.Level.TakeLevelUp(_levelUpValue);
        }
    }
}
