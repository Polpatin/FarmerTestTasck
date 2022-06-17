using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    bool isHolderEmty = true;
    public bool IsHolderEmty
    {
        get { return isHolderEmty; }
    }
    public static Vector3 placeHolderPosition;
    public static Quaternion placeHolderRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isHolderEmty==true)
        {
            placeHolderPosition = transform.position;
            placeHolderRotation = transform.rotation;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Hay")
        {
            isHolderEmty = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hay")
        {
            isHolderEmty = true;
        }
    }
}
