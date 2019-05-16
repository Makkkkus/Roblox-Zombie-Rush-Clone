using UnityEngine;

public class Player : MonoBehaviour
{

    public int health {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health <= 0)
            { 
                KillPlayer();
            }
        }
    }

    private int xp { get; set; }

    public void KillPlayer()
    {
        Destroy(gameObject);
    }
}