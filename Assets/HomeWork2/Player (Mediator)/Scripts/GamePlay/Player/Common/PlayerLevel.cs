
using System;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerLevel
    {
        private readonly int _valueOnInitialize;

        public int Value { get; private set; }  

        public event Action Changed;

        public PlayerLevel(int level)
        {
            Value = level;
            _valueOnInitialize = level;
        }

        public void TakeLevelUp(int levelUpValue)
        {
            Value += levelUpValue;

            Changed?.Invoke();
        }

        public void Reset()
        {
            Value = _valueOnInitialize;
        }
    }
}
