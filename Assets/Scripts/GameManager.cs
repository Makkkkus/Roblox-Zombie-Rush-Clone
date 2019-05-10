using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("The player prefab to spawn")]
    [SerializeField] private GameObject player_Prefab;

    private void Awake()
    {
        Instantiate(player_Prefab);
    }
}