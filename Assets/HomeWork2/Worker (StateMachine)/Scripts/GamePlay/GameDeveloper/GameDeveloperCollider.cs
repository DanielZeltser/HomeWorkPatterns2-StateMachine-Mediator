using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    [RequireComponent(typeof(Rigidbody))]

    public sealed class GameDeveloperCollider : MonoBehaviour
    {
        public bool IsTouchesHomeCollider {  get; private set; }
        public bool IsTouchesOfficeCollider { get; private set; }

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out Home home)) 
                IsTouchesHomeCollider = true;

            if(other.TryGetComponent(out Office office))
                IsTouchesOfficeCollider = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Home home))
                IsTouchesHomeCollider = false;

            if (other.TryGetComponent(out Office office))
                IsTouchesOfficeCollider = false;
        }
    }
}
