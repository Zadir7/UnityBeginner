using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;

        private Vector3 _direction;
        private float _rotationValue;
        private bool _isFiring = false;
        private Transform _gun;

        private void Awake()
        {
            _gun = GetComponentInChildren<Transform>();
        }

        private void Update()
        {
            _rotationValue = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");

            if (Input.GetAxis("Fire1") > 0)
            {
                _isFiring = true;
            }
        }

        private void FixedUpdate()
        {
            Move();
            Rotate();

            if (_isFiring)
            {
                Fire();
                _isFiring = false;
            }
        }

        private void Move()
        {
            Vector3 movementTarget = _direction * _speed * Time.fixedDeltaTime;
            transform.Translate(movementTarget);
        }
        private void Rotate()
        {
            transform.Rotate(new Vector3(0, _rotationValue * _rotationSpeed * Time.fixedDeltaTime, 0));
        }

        private void Fire()
        {

        }
    }
}
