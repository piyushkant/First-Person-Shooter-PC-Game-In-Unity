using UnityEngine;
using System.Collections;

public class instructions : MonoBehaviour {

    private int buttonWidth = 100;
    private int buttonHeight = 25;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 200),
        "Use A,S,W,D To Move"+
        "\nPress Space Bar To Jump"+
        "\nPress Left Mouse Button To Shoot"+
        "\nPress Esc To Quit"+
        "\nWalk Over An Object To Pick It Up");

        if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Back"))
        {
            Application.LoadLevel(1);
        }
    }
}
