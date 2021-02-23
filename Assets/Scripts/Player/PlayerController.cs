using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _gunCooldown = 0.5f;

        private float _currentCooldown;
        private Vector3 _direction;
        private float _rotationValue;
        private bool _isFiring = false;
        private Gun _gun;

        private void Awake()
        {
            _gun = GetComponentInChildren<Gun>();
        }

        private void Update()
        {
            _rotationValue = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");

            if (_currentCooldown > 0)
            {
                _currentCooldown -= Time.deltaTime;
            }
            else if (_currentCooldown < 0)
            {
                _currentCooldown = 0;
            }

            if (Input.GetAxis("Fire1") > 0 && _currentCooldown == 0)
            {
                _isFiring = true;
                _currentCooldown = _gunCooldown;
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
            _gun.Fire();
        }
    }
}
