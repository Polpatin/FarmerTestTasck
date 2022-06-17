using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGrowing : MonoBehaviour
{
    [SerializeField] GameObject Hay;
    private bool isGrassFull=true;
    private float grassHigh=0;
 
    // Start is called before the first frame update
    void Start()
    {
        grassHigh = transform.position.y;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Growing();

    }
    void Growing()
    {
        if (transform.position.y < 0)
        {
            isGrassFull = false;
            transform.position = new Vector3(transform.position.x, grassHigh, transform.position.z);
            grassHigh += 0.3f*Time.deltaTime;
            if (transform.position.y >= -0.4)
            {
                isGrassFull = true;

            }
        }
        else 
        {
            grassHigh = 0;
            isGrassFull = true;
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Sickle");
        //{
        //    print("Im cut");
        //    grassHigh = -3;
        //    transform.position = new Vector3(transform.position.x, grassHigh, transform.position.z);
        //    //intantiate hay
        //}
        if (collision.gameObject.name == "Sickle")
        {
            if (isGrassFull == true)
            {
                grassHigh = -3;
                transform.position = new Vector3(transform.position.x, grassHigh, transform.position.z);
                Instantiate(Hay, new Vector3(transform.position.x, transform.position.y+5, transform.position.z), Quaternion.identity);
              
            }
         
        }
    }

  
}
