using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour 
{
    public float speed;
    private int buttonWidth = 100;
    private int buttonHeight = 25;

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(-3.9f, -5.6f, 0);
	}
	
	// Update is called once per frame
	void Update () 
    {
        float amtTomove = speed * Time.deltaTime;
        transform.Translate(Vector3.forward*amtTomove);

        if (transform.position.y >= 1.35f)
        {
            speed = 0;
        }
	
	}

    void OnGUI()
    {        
        if (GUI.Button(new Rect(50, Screen.height / 2 - buttonHeight / 2+buttonHeight*8, buttonWidth, buttonHeight), "Back"))
        {
            Application.LoadLevel(1);
        }
    }
}
