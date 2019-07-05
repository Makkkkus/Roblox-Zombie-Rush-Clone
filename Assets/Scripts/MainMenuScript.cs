using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    private int selectedMenu = 0;

    [SerializeField] private GameObject[] menu_List;

    private void Awake()
    {
        for(int i = 0; menu_List.Length > i; i++)
        {
            menu_List[i].SetActive(false);
        }
    }

    [SerializeField]
    private void ForceDisableMenu(GameObject menu)
    {
        menu_List[getEnabledMenu(menu)].SetActive(false);
    }
    [SerializeField]
    private void DisableMenu()
    {
        menu_List[selectedMenu].SetActive(false);
    }

    [SerializeField]
    private void EnableMenu(GameObject menu)
    {
        menu_List[selectedMenu].SetActive(false);
        selectedMenu = getEnabledMenu(menu);
        menu_List[getEnabledMenu(menu)].SetActive(true);
        Debug.Log("Enabled menu " + menu_List[getEnabledMenu(menu)]);
    }

    [SerializeField]
    private void QuitGame()
    {
        Application.Quit(0);
    }

    private int getEnabledMenu(GameObject menu)
    {
        for (int i = 0; i < menu_List.Length; i++)
        {
            //If we find the index return the current index
            if (menu_List[i] == menu)
            {
                return i;
            }
        }

        Debug.LogError("Menu not found!");
        return -1;
    }

}