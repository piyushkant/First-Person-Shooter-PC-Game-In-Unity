using UnityEngine;
using System.Collections;

public class skyBox : MonoBehaviour 
{
    public Material day;
    public Material night;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad >= 5)
        {
            RenderSettings.skybox = night;
        }

        if (Time.timeSinceLevelLoad >= 10)
        {
            RenderSettings.skybox = day;
        }
	}
}
