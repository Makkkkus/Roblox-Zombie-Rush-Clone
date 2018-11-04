using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool Save;
    [Space(2)]
    [Header("First gameobject should be the player")]
    public GameObject[] spawnPrefabs;
    Vector3 v3_spawnPos;
    Quaternion spawnRot;
    GameObject playerObject;

	void Start () {
        v3_spawnPos = new Vector3(PlayerPrefs.GetFloat("posX"), PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
        spawnRot = new Quaternion(0, 0, 0, PlayerPrefs.GetFloat("rotW"));

        Instantiate(spawnPrefabs[0], v3_spawnPos, spawnRot);

        playerObject = GameObject.Find("Player(Clone)");
    }

    void Update()
    {
        if (Save)
        {
            PlayerPrefs.SetFloat("rotW", playerObject.transform.rotation.w);
            PlayerPrefs.SetFloat("posX", playerObject.transform.position.x);
            PlayerPrefs.SetFloat("posY", playerObject.transform.position.y);
            PlayerPrefs.SetFloat("posZ", playerObject.transform.position.z);
            PlayerPrefs.Save();
            Debug.Log("Saved");
            Save = false;
        }
    }
}
