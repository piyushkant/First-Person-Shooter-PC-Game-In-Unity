using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform gun;
    public GameObject muzzleFlashPrefab;
    
    public int speed;

    private GameObject instantiatedFlash;
    private Rigidbody instantiatedBullet;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale == 1)
        {
            instantiatedFlash = (GameObject)Instantiate(muzzleFlashPrefab, this.transform.position, this.transform.rotation);
            Destroy(instantiatedFlash, 0.05f);
            instantiatedBullet = (Rigidbody)Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            instantiatedBullet.velocity = transform.TransformDirection(Vector3.forward * speed);
        }
    }
}
    
       

