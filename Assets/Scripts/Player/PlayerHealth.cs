using UnityEngine;

namespace Game
{
    public class PlayerHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private float maximumHealth;
        [SerializeField] private float currentHealth;
        public float MaximumHealth => maximumHealth;
        public float CurrentHealth => currentHealth;

        public void TakeDamage(float damageAmount)
        {
            if (currentHealth - damageAmount <= 0)
            {
                Destroy(this);
                Debug.Log("Game over");
            } else
            {
                currentHealth -= damageAmount;
            }
        }

        public void Heal(float healAmount)
        {
            if (currentHealth + healAmount >= maximumHealth)
            {
                currentHealth = maximumHealth;
            } else
            {
                currentHealth += healAmount;
            }
        }
    }
}
