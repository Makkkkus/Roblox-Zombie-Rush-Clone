using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application exited");
    }
}
