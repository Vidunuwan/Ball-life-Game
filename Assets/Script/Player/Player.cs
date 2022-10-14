using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public int health=100;
    public TextMeshProUGUI healthbar;
    public TextMeshProUGUI gameOver;
    public GameObject dEffect;

    
    // Start is called before the first frame update
    void Start()
    {
        healthbar.text = "Life="+health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x);
        //Enemy e = GetComponent<Enemy>();
        //Debug.Log(e);
    }

    public void takeDamage(int damage)
    {
     
        health -= damage;
        if (health <= 0)
        {
            Instantiate(dEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            gameOver.text = "Game Over...!";
          
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy(Clone)")
        {
            takeDamage(50);
            healthbar.text = "Life=" + health.ToString();

        }
    }

}
