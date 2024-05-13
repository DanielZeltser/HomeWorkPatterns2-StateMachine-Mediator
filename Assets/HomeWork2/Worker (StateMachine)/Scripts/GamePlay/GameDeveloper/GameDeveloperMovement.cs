using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{
    public sealed class GameDeveloperMovement
    {
        private readonly Transform _transform;

        public GameDeveloperMovement(Transform transform) 
        { 
            _transform = transform;
        }

        public void MoveTo(Vector3 target, float speed) => _transform.position = 
            Vector3.MoveTowards(_transform.position, target, speed * Time.deltaTime);

    }
}
