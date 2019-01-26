using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject playerPrefab;
    GameObject playerObject;

    void Start()
    {
        Instantiate(playerPrefab, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
        playerObject = GameObject.Find("Player(Clone)");
    }
}
