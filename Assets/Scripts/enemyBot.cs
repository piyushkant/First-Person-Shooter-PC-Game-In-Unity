using UnityEngine;
using System.Collections;

public class enemyBot : MonoBehaviour 
{  
    public Transform target;
    public Transform gun;
    public float moveSpeed;
    public float rotationSpeed;
    public GameObject ExplosionPrefab;
    public GameObject headPrefab;
    public int hitCount=0;
    public int headShot = 0;
    public GameObject finalExplosionPrefab;
    public GameObject bulletEnemy;
    public GameObject muzzleFlashPrefab;
    public Transform shootPosition;

    public float bulletOffsetX;
    public float bulletOffsetY;
    public float bulletOffsetZ;

    private GameObject clone;
    private GameObject instantiatedMuzzleFlash;
    private bullet Bullet;
    private Transform myTransform;
    private float dist=15;

    void Awake()
    {
        myTransform = transform;   
    }

	// Use this for initialization
	void Start () 
    {
        animation.wrapMode = WrapMode.Loop;
        animation["idle2shoot"].wrapMode = WrapMode.Clamp;
	}
	
	// Update is called once per frame
    void Update()
    {
        int angle = Random.Range(0, 360);

            Vector3 moveDirection = target.position - transform.position;
            Vector3 velocity = rigidbody.velocity;

            if (moveDirection.magnitude < 40 && Time.timeScale == 1)
            {
                if (moveDirection.magnitude < dist)
                {
                    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
                    velocity = Vector3.zero;

                    if (hitCount < 5)
                    {
                        animation.CrossFade("shoot");
                        Vector3 position = new Vector3(gun.position.x + bulletOffsetX,
                            gun.position.y + bulletOffsetY, gun.position.z + bulletOffsetZ);
                        instantiatedMuzzleFlash = (GameObject)Instantiate(muzzleFlashPrefab, shootPosition.transform.position, shootPosition.transform.rotation);
                        instantiatedMuzzleFlash.transform.Rotate(90, 0, angle);
                        Destroy(instantiatedMuzzleFlash, 0.05f);
                        clone = (GameObject)Instantiate(bulletEnemy, shootPosition.transform.position, shootPosition.transform.rotation);
                    }

                    else
                    {
                        Destroy(clone.gameObject);
                        dist = 1;
                        moveSpeed = 5;
                    }

                    if (dist <= 1)
                    {
                        animation.CrossFade("hit");
                    }
                }

                else
                {
                    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
                    myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
                    animation.CrossFade("run");
                }
            }

            else
            {
                velocity = Vector3.zero;
                animation.CrossFade("idle");
            }
        
    }

   void OnTriggerEnter(Collider otherObject)
   {
       if (otherObject.tag == "bullet")
       {
           hitCount++;
           Instantiate(ExplosionPrefab, transform.position, transform.rotation);

           if (hitCount > 10)
           {
               audio.Play();
               Instantiate(finalExplosionPrefab, transform.position, transform.rotation);
               Destroy(gameObject);
           }
       }

       if (otherObject.tag == "head")
       {
           headShot++;
       }
    }
}
