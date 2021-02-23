using UnityEngine;

namespace Game
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private float _damage;

        public void Fire()
        {
            Bullet bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.Initialize(_damage);
        }
    }
}
