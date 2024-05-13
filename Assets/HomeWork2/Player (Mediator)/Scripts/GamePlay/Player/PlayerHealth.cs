
namespace HomeWork2.MediatorPattern.GamePlay
{
    public sealed class PlayerHealth
    {
        private readonly int _valueOnInitialize;

        public int Value { get; private set; }

        public PlayerHealth(int health)
        {
            Value = health;
            _valueOnInitialize = health;
        }

        public void TakeDamage(int damage)
        {
            Value -= damage;

            if(Value < 0) 
                Value = 0;
        }

        public void Reset()
        {
            Value = _valueOnInitialize;
        }
    }
}
