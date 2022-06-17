using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayController : MonoBehaviour
{
    Rigidbody rb;

    Vector3 positionONBack;
    Quaternion rotationOnBack;
    public static int numberOfTheHay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Farmer")
        {
            numberOfTheHay++;
            print("number of hay " + numberOfTheHay);
            if (numberOfTheHay == 1)
            {
                //print("i am colided");
                positionONBack = GameObject.Find("Farmer/PlaceForHay").transform.position;
                rotationOnBack = GameObject.Find("Farmer/PlaceForHay").transform.rotation;

                rb.constraints = RigidbodyConstraints.FreezeAll;
                transform.position = positionONBack;
                transform.rotation = rotationOnBack;

                rb.constraints = RigidbodyConstraints.FreezeAll;
                gameObject.transform.SetParent(GameObject.Find("Farmer").transform);

                GetComponentInChildren<PlaceHolder>().enabled = true;
            }

            if(numberOfTheHay>1 && numberOfTheHay<40)
            {

                transform.position = PlaceHolder.placeHolderPosition;
                transform.rotation = PlaceHolder.placeHolderRotation;

                rb.constraints = RigidbodyConstraints.FreezeAll;

                gameObject.transform.SetParent(GameObject.Find("Farmer").transform);

                GetComponentInChildren<PlaceHolder>().enabled = true;
                GetComponent<WiggleHayStack>().enabled = true;
            }

        }
    }
}
