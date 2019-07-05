using UnityEngine;

public class Player : MonoBehaviour
{

    public int health {
        get => health;
        set
        {
            health = value;
            if (health <= 0)
            {
                KillPlayer();
            }
        }
    }

    private int xp {get => xp; set => xp = value; }

    private float current;
    private float previous;
    public float velocity { get => velocity;
        set
        {
            velocity = value;
            if (velocity <= .1 && velocity >= -.1)
                velocity = 0;

            if (velocity >= 7f)
            {
                health -= Mathf.RoundToInt(velocity / 10);
            }

        }
    }

    public void KillPlayer()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        previous = current;
        current = transform.position.y;

        //velocity = (current - previous) / Time.deltaTime;
    }
}