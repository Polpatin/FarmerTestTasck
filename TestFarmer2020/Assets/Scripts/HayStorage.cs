using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayStorage : MonoBehaviour
{
    bool standNearBarn = false;
    float speed = 0.07f;
    Vector3 barnDoorPosition;
    // Start is called before the first frame update
    void Start()
    {
        barnDoorPosition = GameObject.Find("BarnDoor").transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (standNearBarn == true)
        {
            FlyToTheBarn();
        }
    }
    void FlyToTheBarn()
    {
       
        if (GetComponentInChildren<PlaceHolder>().IsHolderEmty == true)
        {
            // transform.Translate(barnDoorPosition * speed * Time.deltaTime);
            GetComponent<HayController>().enabled = false;
            GetComponent<WiggleHayStack>().enabled = false;

            transform.position = Vector3.MoveTowards(transform.position, barnDoorPosition, speed);

           
            gameObject.transform.SetParent(GameObject.Find("BarnDoor").transform);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Barn")
        {
            print("Stand near the barn " + standNearBarn);
            standNearBarn = true;
            HayController.numberOfTheHay = 0;

        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Barn")
    //    {
    //        print("Stand near the barn " + standNearBarn);
    //        standNearBarn = false;
    //    }
    //}
}
