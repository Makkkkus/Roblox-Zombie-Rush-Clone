using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public int health = 100;
    [HideInInspector] public int xp = 0;

    private void Update()
    {
        if (health <= 0) Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}