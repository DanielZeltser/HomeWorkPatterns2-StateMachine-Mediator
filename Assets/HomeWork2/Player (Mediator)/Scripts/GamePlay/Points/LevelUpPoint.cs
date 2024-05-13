using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class LevelUpPoint : MonoBehaviour
    {
        public Vector3 Position => transform.position;
    }
}
