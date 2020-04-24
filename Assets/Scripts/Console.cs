using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    public bool consoleEnabled = false;
    private bool alreadyRan = false;

    private static GameObject console;

    private GameObject windows;
    private TMPro.TextMeshProUGUI inputFieldText;
    private TMPro.TextMeshProUGUI textFieldText;

    public GameObject textField;
    public GameObject inputField;

    private void Start()
    {
        console = gameObject;

        inputFieldText = inputField.GetComponent<TMPro.TextMeshProUGUI>();
        textFieldText = textField.GetComponent<TMPro.TextMeshProUGUI>();
        gameObject.SetActive(false);
    }

    private void Update() {
        if (!consoleEnabled)
        {
            Console.DisableConsole();
        }

        UpdateConsole();
    }

    private void UpdateConsole()
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

    public static void EnableConsole()
    {
        console.SetActive(true);
    }

    public static void DisableConsole()
    {
        console.SetActive(false);
    }
}
