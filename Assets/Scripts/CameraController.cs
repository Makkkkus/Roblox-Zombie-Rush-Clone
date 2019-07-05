using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(0.1f, 2)]
    [SerializeField] private float sensitivity = 1;

    GameObject player;

    float mouseX = 0;
    float mouseY = 0;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity;

    }

    private void FixedUpdate()
    {
        player.transform.Rotate(0, mouseX, 0);
        transform.Rotate(0, mouseX, 0, Space.World);
        transform.Rotate(-mouseY, 0, 0, Space.Self);
        transform.position = player.transform.position + new Vector3(0, .8f);
    }
}
