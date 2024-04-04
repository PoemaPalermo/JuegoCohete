using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTeclado : MonoBehaviour
{
    public float speed;
    public float movX;
    public float maxX= 11.5f;
    public float minX= -11.5f;
    public float movY;
    public float maxY = 2.3f;
    public float minY = -4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        transform.Translate(movX*speed * Time.deltaTime,0,0);

        if(transform.position.x>maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        movY = Input.GetAxis("Vertical");
        transform.Translate(0, movY * speed * Time.deltaTime, 0);

        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY , transform.position.z);
        }
        else if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY , transform.position.z);
        }
    }
}
