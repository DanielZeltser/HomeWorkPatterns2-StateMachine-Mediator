using HomeWork2.MediatorPattern.UI;
using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class GameplayMediator : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private PlayerCollider _playerCollider;

        [SerializeField] private PlayerLevelView _playerLevelView;
        [SerializeField] private PlayerHealthView _playerHealthView;

        [SerializeField] private RestartButton _restartButton;

        public int PlayerHealth => _player.Health.Value;
        private int PlayerLevel => _player.Level.Value;

        private void OnEnable()
        {
            _restartButton.Restarted += OnRestart;

            _playerCollider.UpdatedPlayerHealthView += UpdatePlayerHealthView;
            _playerCollider.UpdatedPlayerLevelView += UpdatePlayerLevelView;
        }

        private void OnDisable()
        {
            _restartButton.Restarted -= OnRestart;

            _playerCollider.UpdatedPlayerHealthView -= UpdatePlayerHealthView;
            _playerCollider.UpdatedPlayerLevelView -= UpdatePlayerLevelView;
        }

        private void OnRestart()
        {
            _player.ResetPosition();
            _player.ResetProperties();

            UpdatePlayerHealthView();
            UpdatePlayerLevelView();
        }

        private void UpdatePlayerHealthView() => _playerHealthView.UpdateText(PlayerHealth);
        private void UpdatePlayerLevelView() => _playerLevelView.UpdateText(PlayerLevel);

    }
}