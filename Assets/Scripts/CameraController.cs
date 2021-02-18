using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    private void Start()
    {
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = player.transform.position - offset;
    }
}
