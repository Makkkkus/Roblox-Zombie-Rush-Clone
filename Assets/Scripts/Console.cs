using UnityEngine;

public class Console : MonoBehaviour
{
    private bool consoleEnabled = false;
    private bool alreadyRan = false;

    private GameObject windows;
    private TMPro.TextMeshProUGUI inputFieldText;
    private TMPro.TextMeshProUGUI textFieldText;

    private void Awake()
    {
        windows = GameObject.Find("Windows");
        windows.SetActive(false);

        GameObject textField = GameObject.Find("TextField");
        GameObject inputField = GameObject.Find("InputField");

        inputFieldText = inputField.GetComponent<TMPro.TextMeshProUGUI>();
        textFieldText = textField.GetComponent<TMPro.TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Console"))
        {
            consoleEnabled = !consoleEnabled;
            windows.SetActive(consoleEnabled);
            Cursor.visible = consoleEnabled;
        }

        if (!consoleEnabled)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            alreadyRan = false;
            return;
        }

        if (consoleEnabled) updateConsole();

    }

    private void updateConsole()
    {
        if (!alreadyRan)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            alreadyRan = true;
        }

        if (Input.GetButtonDown("Submit"))
        {
            switch (inputFieldText.text)
            {
                case "test":
                    addText("Hello");
                    break;
                default:
                    addText("ERROR: Command not found! Please try a different command.");
                    break;
            }
        }

    }

    private void addText(string text)
    {
        textFieldText.SetText(textFieldText.text + "\n" + text);
    }
}
