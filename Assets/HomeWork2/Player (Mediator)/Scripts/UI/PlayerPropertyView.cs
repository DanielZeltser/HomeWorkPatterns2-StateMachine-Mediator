using UnityEngine;
using TMPro;

namespace HomeWork2.MediatorPattern.UI
{
    public sealed class PlayerPropertyView : MonoBehaviour
    {
        [SerializeField] private string _title;
        [SerializeField] private TextMeshProUGUI _view;

        public void UpdateText(int value)
        {
            _view.text = _title + value.ToString();
        }
    }
}
