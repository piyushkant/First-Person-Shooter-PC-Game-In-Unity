using UnityEngine;
using System.Collections;

public class compass : MonoBehaviour
{
    public Texture compassTexture;
    float playerDirection;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerDirection = GameObject.FindGameObjectWithTag("player").transform.rotation.eulerAngles.y;
	}

    void OnGUI()
    {
        //GUI.DrawTexture(new Rect(Screen.width - 100, 30, 40, 10), compassTexture);
        //GUI.Label(new Rect(10, 10, 120, 20), "Direction: " + playerDirection.ToString());
    }
}
