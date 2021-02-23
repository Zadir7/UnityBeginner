using UnityEngine;

namespace Game
{
    public class HealthPickup : MonoBehaviour
    {
        [Range(0,500)]
        [SerializeField] private float healAmount = 50;

        private IHealth picker;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out picker))
            {
                picker.Heal(healAmount);
                Destroy(gameObject);
            }
        }
    }
}
