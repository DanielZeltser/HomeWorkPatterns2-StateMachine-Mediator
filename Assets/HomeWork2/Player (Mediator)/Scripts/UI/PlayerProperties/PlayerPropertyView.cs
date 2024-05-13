using UnityEngine;
using TMPro;
using HomeWork2.MediatorPattern.GamePlay;

namespace HomeWork2.MediatorPattern.UI
{
    public class PlayerPropertyView : MonoBehaviour
    {
        [SerializeField] private string _title;
        [SerializeField] private TextMeshProUGUI _view;
        [SerializeField] private PlayerConfig _playerConfig;

        protected PlayerConfig Config => _playerConfig;

        public void UpdateText(int value)
        {
            _view.text = _title + value.ToString();
        }
    }
}
