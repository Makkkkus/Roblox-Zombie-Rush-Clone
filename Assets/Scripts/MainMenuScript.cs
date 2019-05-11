using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    private int selectedMenu = 0;
    private bool menuOpen = false;

    [SerializeField] private GameObject[] menu_List;

    private void Awake()
    {
        int length = menu_List.Length;

        for(int i = 0; length > i; i++)
        {
            menu_List[i].SetActive(false);
        }
    }

    public void ForceDisableMenu(int menuNumber)
    {
        menu_List[menuNumber].SetActive(false);
    }
    public void DisableMenu()
    {
        menu_List[selectedMenu].SetActive(false);
    }

    public void EnableMenu(int menuNumber)
    {
        menu_List[selectedMenu].SetActive(false);
        selectedMenu = menuNumber;
        menu_List[menuNumber].SetActive(true);
        Debug.Log("Enabled menu " + menu_List[menuNumber]);
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}