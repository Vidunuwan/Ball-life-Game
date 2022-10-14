using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float bSpeed = 20;
    int damage = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up* Time.deltaTime * bSpeed);
        //BouboundaryLine(-8.5f, 8.5f, 4.5f, -4.5f);
    }
    /*void BouboundaryLine(float left, float right, float up, float down)
    {
        if (transform.position.x > right)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < left)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > up)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < down)
        {
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        //Debug.Log(enemy);
        if(enemy != null)
        {
            enemy.takeDamage(damage);
        }
        if (collision.name == "Wall" || collision.name=="Enemy" || collision.name== "Plasma(Clone)")
        {
            Destroy(gameObject);
        }
        
    }




}
