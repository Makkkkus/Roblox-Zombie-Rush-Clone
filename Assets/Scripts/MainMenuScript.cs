using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    private int selectedMenu = 0;

    [SerializeField] private GameObject[] menu_List;

    private void Awake()
    {
        int length = menu_List.Length;

        for(int i = 0; length > i; i++)
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

    int getEnabledMenu(GameObject menu)
    {
        Menu menuScript = menu.GetComponent<Menu>();
        return menuScript.menuNumber;
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}