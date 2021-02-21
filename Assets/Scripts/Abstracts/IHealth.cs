namespace Game
{
    public interface IHealth
    {
        public float MaximumHealth { get; }
        public float CurrentHealth { get; }

        public void TakeDamage(float damageAmount);
        public void Heal(float healAmount);
    }
}
