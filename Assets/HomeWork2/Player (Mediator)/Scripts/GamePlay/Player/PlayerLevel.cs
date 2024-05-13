
namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerLevel
    {
        private const int LevelUpValue = 1;
        
        private readonly int _valueOnInitialize;

        public int Value { get; private set; }

        public PlayerLevel(int level)
        {
            Value = level;
            _valueOnInitialize = level;
        }

        public void LevelUp()
        {
            Value += LevelUpValue;
        }

        public void Reset()
        {
            Value = _valueOnInitialize;
        }
    }
}
