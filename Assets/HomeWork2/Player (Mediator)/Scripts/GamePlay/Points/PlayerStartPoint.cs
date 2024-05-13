using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerStartPoint : MonoBehaviour
    {
        public Vector3 Position => transform.position;
    }
}
