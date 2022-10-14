using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
    float posY;
    public GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void Spawn()
    {
        posY = Random.Range(-4,4);
        Vector3 spawn = new Vector3(8, posY, 0);
        Instantiate(enemy,spawn, transform.rotation);
    }
}
