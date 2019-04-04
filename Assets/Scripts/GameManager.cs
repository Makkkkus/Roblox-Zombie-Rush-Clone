using UnityEngine;

public class GameManager : MonoBehaviour { 
    [Tooltip("The player prefab to spawn")]
    [SerializeField] private GameObject player;

    private void Start()
    {
        Instantiate(player, new Vector3(0, 0, 0), new Quaternion(0,0,0,0));   
    }
}