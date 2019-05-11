using UnityEngine;

public class Player : MonoBehaviour
{

    //private GameManager gameManager;

    public Player()
    { 
    }

    public GameObject GetPlayerObject()
    {
        return gameObject;
    }

    public Player GetPlayer()
    {
        return this;
    }

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
                //gameManager.KillPlayer();
            }
        }
    }

    private int xp { get; set; }
}