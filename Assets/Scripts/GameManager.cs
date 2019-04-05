using UnityEngine;

public class GameManager : MonoBehaviour { 
    [Tooltip("The player prefab to spawn")]
    [SerializeField] private GameObject player;

    private void Awake()
    {
        Instantiate(player);
    }
}