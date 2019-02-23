using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int xp = 0;
    public Vector3 coords;

    void Start() {

    }

    void Update() {
        coords = transform.position;
    }
}
