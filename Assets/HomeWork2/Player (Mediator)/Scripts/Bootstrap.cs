using UnityEngine;
using HomeWork2.MediatorPattern.GamePlay;

namespace HomeWork2.MediatorPattern
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private PlayerStatsMediator _playerStatsMediator;
        [SerializeField] private GameRestartMediator _gameRestartMediator;

        private void Awake()
        {
            _player.Initialize();

            _playerStatsMediator.Initialize();
            _gameRestartMediator.Initialize();
        }
    }
}
