using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
    public Texture backgroundTexture;
    private int buttonWidth = 100;
    private int buttonHeight = 25;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "New Game"))
        {
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, (Screen.height / 2 - buttonHeight / 2)+buttonHeight, buttonWidth, buttonHeight), "Instructions"))
        {
            Application.LoadLevel(5);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, (Screen.height / 2 - buttonHeight / 2) + buttonHeight*2, buttonWidth, buttonHeight), "Credits"))
        {
            Application.LoadLevel(6);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, (Screen.height / 2 - buttonHeight / 2) + buttonHeight*3, buttonWidth, buttonHeight), "Exit"))
        {
            Application.Quit();
        }
    }
}
