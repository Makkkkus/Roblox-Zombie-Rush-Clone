using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rb;

    private const float bulletForce = 50f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.AddForce(Vector3.forward * bulletForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            player.health -= 5;
            Destroy(gameObject);
        }

        //Debug.LogWarning("This is not supposed to happen");
    }
}
