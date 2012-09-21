using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    public int hitCount = 0;
    public GameObject ExplosionPrefab;
    public GameObject finalExplosionPrefab;
    public int headCount = 0;
    public float rotateSpeed = 60f;
    public GameObject quitPrefab;
    
    private static int health;
    private static string data;
    private static string fuel;
    private static string keyBox;
    private GameObject instantiatedQuit;

    

	// Use this for initialization
	void Start ()
    {
        health = 400;
        data = "Find";
        fuel = "Find";
        keyBox = "Find";
	}
	
	// Update is called once per frame
	void Update () 
    { 
        //if (Input.GetKeyDown(KeyCode.Escape))
        /*if (Input.GetKey("escape"))
        {
            //Time.timeScale = 0;
            //GetComponent<quit>().enabled = true;
            instantiatedQuit =(GameObject)Instantiate(quitPrefab, this.transform.position, this.transform.rotation); 
        }*/
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "bulletEnemy")
        {
            hitCount++;
            health -= 2;
            //Instantiate(ExplosionPrefab, transform.position, transform.rotation);

            if (hitCount > 200)
            {
                Instantiate(finalExplosionPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
                Application.LoadLevel(4);
            }
        }

        if (otherObject.tag == "head")
        {
            headCount++;
            if (headCount > 5)
            {
                Instantiate(finalExplosionPrefab, transform.position, transform.rotation);
                DestroyObject(gameObject);
                Application.LoadLevel(4);
            }
        }

        if (otherObject.tag == "data")
        {
            Destroy(GameObject.FindGameObjectWithTag("data").gameObject);
            Instantiate(ExplosionPrefab, transform.position, transform.rotation);
            data = "Done";
        }

        if (otherObject.tag == "fuel")
        {
            //if (GameObject.FindGameObjectWithTag("data").gameObject != true)
            {
                Destroy(GameObject.FindGameObjectWithTag("fuel").gameObject);
                Instantiate(ExplosionPrefab, transform.position, transform.rotation);
                fuel = "Done";
            }
        }

        if (otherObject.tag == "keyBox")
        {
            //if (GameObject.FindGameObjectWithTag("fuel").gameObject != true)
            {
                Destroy(GameObject.FindGameObjectWithTag("keyBox").gameObject);
                Instantiate(ExplosionPrefab, transform.position, transform.rotation);
                keyBox = "Done";
            }
        }

        if (otherObject.tag == "spaceShip")
        {
           // if (GameObject.FindGameObjectWithTag("keyBox").gameObject != true)
            {
                Application.LoadLevel(3);
            }
        }
    }

    void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 120, 20), "Health: " + collision.health.ToString());
        //GUI.Label(new Rect(10, 30, 120, 20), "Data: " + collision.data.ToString());
       // GUI.Label(new Rect(10, 50, 120, 20), "Fuel: " + collision.fuel.ToString());
        //GUI.Label(new Rect(10, 70, 120, 20), "Key Box: " + collision.keyBox.ToString());
        //GUI.Label(new Rect(10, 90, 120, 20), "Time: " + (Time.timeSinceLevelLoad).ToString());
    }
}
