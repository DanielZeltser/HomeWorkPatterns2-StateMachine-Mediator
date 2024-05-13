using HomeWork2.MediatorPattern.GamePlay;
using UnityEngine;

namespace HomeWork2.MediatorPattern.UI
{
    public sealed class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private GameplayMediator _gameplayMediator;
        [SerializeField] private RestartButton _restartButton;

        private void Update()
        {
            if (_gameplayMediator.PlayerHealth == 0)
                ShowRestartButton();
        }

        private void ShowRestartButton() => _restartButton.gameObject.SetActive(true);
    }
}
