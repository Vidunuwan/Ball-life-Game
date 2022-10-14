using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject Bullet;
    public AudioSource fireEffact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireEffact.Play();
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
