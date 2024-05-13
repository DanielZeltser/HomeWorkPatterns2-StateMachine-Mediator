
namespace HomeWork2.MediatorPattern.UI
{
    public sealed class PlayerLevelView : PlayerPropertyView
    {
        private void OnValidate()
        {
            UpdateText(Config.Level);
        }

    }
}
