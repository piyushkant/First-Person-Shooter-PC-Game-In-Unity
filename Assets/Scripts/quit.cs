using UnityEngine;
using System.Collections;

public class quit: MonoBehaviour
{
    //public GUISkin NewSkin;
    private int buttonWidth = 200;
    private int buttonHeight = 50;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        if (Input.GetKey("escape"))
        {
           // Time.timeScale = 1;
            Destroy(gameObject);
        }
    }

    void OnGUI()
    {
        //GUI.skin = NewSkin;

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Quit To Main Menu"))
        {
            Time.timeScale = 1;
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2+buttonHeight*2, buttonWidth, buttonHeight), "Back To Game"))
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}
