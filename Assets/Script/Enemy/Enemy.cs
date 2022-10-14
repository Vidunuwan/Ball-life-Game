using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public GameObject dEffect;

    private GameObject player;
    public AudioSource dethEffect;


    //private Rigidbody2D rb;
   



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        //Debug.Log(player);

        // transform.position =new Vector3(8,player.position.y,0);
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(8f, player.transform.position.y), 2f * Time.deltaTime);
        }
    }

    public void takeDamage(int damage)
    {
        
        health -= damage;
        if (health <= 0)
        {
           
            Destroy(gameObject);
            dethEffect.Play();
            Instantiate(dEffect, transform.position, transform.rotation);
        }
    }



}
