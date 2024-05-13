using System;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork2.MediatorPattern.UI
{
    [RequireComponent(typeof(Button))]

    public sealed class RestartButton : MonoBehaviour
    {
        private Button _button;

        public event Action Restarted;

        public void Initialize()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(OnRestart);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnRestart);
        }

        private void OnRestart()
        {
            Restarted?.Invoke();
            Hide();
        }

        private void Hide() => gameObject.SetActive(false);
    }
}
