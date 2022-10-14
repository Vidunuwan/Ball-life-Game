using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plasma : MonoBehaviour
{
    int speed = 20;
    int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Wall" || collision.name == "Player" || collision.name== "Bullet(Clone)" || collision.name== "Sheild")
        {
            Destroy(gameObject);
        }
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            player.takeDamage(damage);
            player.healthbar.text = "Life=" + player.health.ToString();
        }
    }


}
