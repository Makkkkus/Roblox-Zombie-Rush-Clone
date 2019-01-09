using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject playerPrefab;
    GameObject playerObject;

	void Start ()
    {
        playerObject = GameObject.Find("Player(Clone)");
    }
}
