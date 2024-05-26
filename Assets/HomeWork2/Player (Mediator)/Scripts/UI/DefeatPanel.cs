
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork2.MediatorPattern.UI
{
    public sealed class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private Button _restartButton;

        public void ShowRestartButton() => _restartButton.gameObject.SetActive(true);
    }
}
