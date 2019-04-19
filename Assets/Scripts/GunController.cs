using UnityEngine;

public class GunController : MonoBehaviour
{
    public int gunDamage = 5;
    public GameObject bullet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }
}
