using UnityEngine;
using System.Collections;

public class lose : MonoBehaviour
{
    public Texture backgroundTexture;

    private int buttonWidth = 200;
    private int buttonHeight = 50;

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

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Game Over.\n Press To Restart Game"))
        {
            Application.LoadLevel(2);
        }


        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2 + buttonHeight, buttonWidth, buttonHeight), "Go To Main Menu"))
        {
            Application.LoadLevel(1);
        }
    }
}
