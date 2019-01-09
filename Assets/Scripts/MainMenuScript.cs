using UnityEngine;

public class MainMenuScript : MonoBehaviour
{

    [SerializeField]
    private GameObject PlayMenu, OptionsMenu;


    void Start()
    {
        PlayMenu_Disable();
        OptionsMenu_Disable();
    }

    #region PlayMenu
    public void PlayMenu_Enable()
    {
        PlayMenu.SetActive(true);
    }

    public void PlayMenu_Disable()
    {
        PlayMenu.SetActive(false);
    }

    public void PlayMenu_Singleplayer()
    {

    }

    public void PlayMenu_Multiplayer()
    {

    }
    #endregion

    #region OptionsMenu
    public void OptionsMenu_Enable()
    {
        OptionsMenu.SetActive(true);
    }

    public void OptionsMenu_Disable()
    {
        OptionsMenu.SetActive(false);
    }
    #endregion

    #region QuitButton
    public void QuitButton_Quit()
    {
        Application.Quit();
        Debug.Log("Game quit sucessfully");
    }
    #endregion
}
