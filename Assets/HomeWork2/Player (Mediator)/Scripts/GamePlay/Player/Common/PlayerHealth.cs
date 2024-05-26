
using System;

namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerHealth
    {
        private readonly int _valueOnInitialize;
        
        public int Value { get; private set; }

        public event Action PlayerDead;
        public event Action Changed;

        public PlayerHealth(int health)
        {
            Value = health;
            _valueOnInitialize = health;
        }

        public void TakeDamage(int damage)
        {
            Value -= damage;

            if(Value <= 0)
            {
                Value = 0;
                PlayerDead?.Invoke();
            }

            Changed?.Invoke();
        }

        public void Reset()
        {
            Value = _valueOnInitialize;
        }
    }
}
