using HomeWork2.MediatorPattern.UI;
using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class GameRestartMediator : MonoBehaviour
    {
        [SerializeField] private DefeatPanel _defeatPanel;

        [SerializeField] private PlayerStatsMediator _playerStatsMediator;
        [SerializeField] private Player _player;

        public void Initialize()
        {
            _player.Health.PlayerDead += _defeatPanel.ShowRestartButton;
        }

        private void OnDestroy()
        {
            _player.Health.PlayerDead -= _defeatPanel.ShowRestartButton;
        }

        public void Restart() // Is calling in RestartButton in OnClick()
        {
            _player.ResetPosition();
            _player.ResetProperties();

            _playerStatsMediator.UpdatePlayerPropertiesView();
        }
    }
}