using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        public float speed;

        private Vector3 _direction;

        private void Update()
        {
            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");
        }

        private void FixedUpdate()
        {
            var movementTarget = _direction * speed * Time.fixedDeltaTime;
            transform.Translate(movementTarget);
        }

    }
}
