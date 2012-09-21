using UnityEngine;
using System.Collections;

public class bulletEnemy : MonoBehaviour 
{
    public float bulletSpeed;
 
	// Use this for initialization
	void Start () 
    {       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.FindGameObjectWithTag("enemy")!=null)
        {
            float amtToMove = bulletSpeed * Time.deltaTime;
            transform.Translate(Vector3.forward * amtToMove);

            if (transform.position.magnitude - GameObject.FindGameObjectWithTag("enemy").transform.position.magnitude > 40 ||
                transform.position.magnitude - GameObject.FindGameObjectWithTag("enemy").transform.position.magnitude < -40)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider otherObject) 
    {
        if (otherObject.tag == "player")
        {
            Destroy(gameObject);  
        }
    }
}
