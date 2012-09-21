using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour 
{
    public float bulletSpeed;

	// Use this for initialization
	void Start () 
    {       
	}
	
	// Update is called once per frame
	void Update ()
    {  
        if (GameObject.FindGameObjectWithTag("player") != null)
        {
            float amtToMove = bulletSpeed * Time.deltaTime;
            transform.Translate(Vector3.forward * amtToMove);

            if (transform.position.magnitude - GameObject.FindGameObjectWithTag("player").transform.position.magnitude > 20 ||
                transform.position.magnitude - GameObject.FindGameObjectWithTag("player").transform.position.magnitude < -20)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider otherObject) 
    {
        if (otherObject.tag == "enemy")
        {
            Destroy(gameObject);  
        }
    }
}
