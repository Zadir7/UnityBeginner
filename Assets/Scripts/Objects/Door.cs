using UnityEngine;

namespace Game
{
    public class Door : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            OpenDoor();
        }

        private void OnTriggerExit(Collider other)
        {
            CloseDoor();
        }

        private void OpenDoor()
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = false;
        }
        private void CloseDoor()
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<MeshCollider>().enabled = true;
        }
    }
}
