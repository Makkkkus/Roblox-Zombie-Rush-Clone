using UnityEngine;
using UnityEngine.UI;

public class IngameGUISystem : MonoBehaviour
{   
    private Player player;
    private Text healthText;
    private int playerHealth = 100;

    private void Awake()
    {
        GameObject healthTextObject = GameObject.Find("HealthText");
        healthText = healthTextObject.GetComponent<Text>();

        GameObject playerObject = GameObject.Find("Player(Clone)");
        player = playerObject.GetComponent<Player>();
    }

    private void Update()
    {
        player.health = playerHealth;

        healthText.text = "Health: " + playerHealth;
    }
}
