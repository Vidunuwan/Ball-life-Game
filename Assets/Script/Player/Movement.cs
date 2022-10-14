using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float pSpeed = 10;
    private float inputVerticle;
    private float inputHorizontal;
    //public float inputRotate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputRotate = Input.GetAxis("Mouse X");
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVerticle = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right*Time.deltaTime*pSpeed* inputHorizontal);
        transform.Translate(Vector2.up * Time.deltaTime * pSpeed * inputVerticle);
        //transform.Rotate(Vector3.forward * Time.deltaTime * 50* inputRotate);

        BouboundaryLine(-8f, 8f,4f,-4f);
    }
    void BouboundaryLine(float left,float right,float up,float down)
    {
        if (transform.position.x > right)
        {
            transform.position = new Vector2(right, transform.position.y);
        }
        if (transform.position.x < left)
        {
            transform.position = new Vector2(left, transform.position.y);
        }
        if (transform.position.y > up)
        {
            transform.position = new Vector2(transform.position.x,up);
        }
        if (transform.position.y < down)
        {
            transform.position = new Vector2(transform.position.x,down);
        }
    }
}
