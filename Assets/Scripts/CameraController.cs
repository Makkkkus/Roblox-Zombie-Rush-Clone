using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(0.1f,2)]
    public float sensitivity;
    public Vector3 offset;
    public bool invertMouse = false;

    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (invertMouse) mouseY = -mouseY;
        
    }
}
