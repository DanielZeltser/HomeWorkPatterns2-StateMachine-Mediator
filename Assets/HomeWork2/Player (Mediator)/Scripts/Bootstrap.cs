using UnityEngine;
using HomeWork2.MediatorPattern.GamePlay;
using HomeWork2.MediatorPattern.UI;

namespace HomeWork2.MediatorPattern
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private RestartButton _restartButton;

        private void Awake()
        {
            _player.Initialize();
            _restartButton.Initialize();
        }
    }
}
