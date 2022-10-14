using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public GameObject plasma;
    public float startTime = 0;
    public float spawnIntervel = 0.2f;

    public AudioSource fireEffect;
    //bool isFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        if (collision.name == "Player")
        {
            InvokeRepeating("Fire",startTime,spawnIntervel);
            
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            CancelInvoke();
            
        }
    }
    void Fire()
    {
        //fireEffect.Play();
        Instantiate(plasma, transform.position, transform.rotation);
;
    }
}
