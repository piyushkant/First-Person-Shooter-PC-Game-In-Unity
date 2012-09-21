using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GameObject quitPrefab;
    GameObject instantiatedQuit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("escape"))
        {
            Time.timeScale = 0;
            //GetComponent<quit>().enabled = true;
            instantiatedQuit = (GameObject)Instantiate(quitPrefab, this.transform.position, this.transform.rotation);
        }	
	}
}
