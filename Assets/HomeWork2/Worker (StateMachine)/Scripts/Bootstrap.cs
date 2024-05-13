using HomeWork2.Worker.GamePlay;
using UnityEngine;

namespace HomeWork2.Worker
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameDeveloper _gameDeveloper;

        private void Awake()
        {
            _gameDeveloper.Initialize();
        }
    }
}
