using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : MonoBehaviour
{
    public GameObject sheild;
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(sheild, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
