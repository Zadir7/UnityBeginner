using UnityEngine;

namespace Game {
    public class Bullet : MonoBehaviour
    {
        private float _damage;
        private float _lifetime = 5.0f;
        private float _lifetimeLeft;
        private float _speed = 5.0f;
        private IHealth _health;

        private void Update()
        {
            transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));
            if (_lifetimeLeft <= 0)
            {
                Destroy(gameObject);
            } else
            {
                _lifetimeLeft -= Time.deltaTime;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (TryGetComponent<IHealth>(out _health))
            {
                _health.TakeDamage(_damage);
            }
            Destroy(gameObject);
        }

        public void Initialize(float damage)
        {
            _lifetimeLeft = _lifetime;
            _damage = damage;
        }
    } 
}
