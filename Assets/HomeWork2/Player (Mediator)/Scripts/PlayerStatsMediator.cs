using HomeWork2.MediatorPattern.UI;
using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerStatsMediator : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private PlayerPropertyView _playerLevelView;
        [SerializeField] private PlayerPropertyView _playerHealthView;

        public void Initialize()
        {
            UpdatePlayerPropertiesView();

            _player.Health.Changed += UpdatePlayerHealthView;
            _player.Level.Changed += UpdatePlayerLevelView;
        }

        private void OnDestroy()
        {
            _player.Health.Changed -= UpdatePlayerHealthView;
            _player.Level.Changed -= UpdatePlayerLevelView;
        }

        public void UpdatePlayerPropertiesView()
        {
            UpdatePlayerHealthView();
            UpdatePlayerLevelView();
        }

        private void UpdatePlayerHealthView() => _playerHealthView.UpdateText(_player.Health.Value);
        private void UpdatePlayerLevelView() => _playerLevelView.UpdateText(_player.Level.Value);

    }
}