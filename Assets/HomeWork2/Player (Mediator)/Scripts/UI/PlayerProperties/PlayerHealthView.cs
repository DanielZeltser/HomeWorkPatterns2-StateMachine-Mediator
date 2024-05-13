
namespace HomeWork2.MediatorPattern.UI
{
    public sealed class PlayerHealthView : PlayerPropertyView
    {
        private void OnValidate()
        {
            UpdateText(Config.Health);
        }

    }
}
