using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float rotationSpeed = 15;
    [SerializeField] private Joystick myJoystick;

    float joysticHorizontal;
    float joysticVertical;
 
    
    void Update()
    {
        //For Keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        // ForJoystick
     
        joysticHorizontal = myJoystick.Horizontal;
        joysticVertical = myJoystick.Vertical;

        Vector3 translate = (new Vector3(joysticHorizontal, 0, joysticVertical));
        translate.Normalize();
        transform.Translate(translate * speed * Time.deltaTime, Space.World);

        if (translate != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(translate, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


    }
    public void CutTheGrass()
    {

        //for button
    }
    public  bool IsRuning()
    {
        //this is for AnimationController
        if (joysticHorizontal != 0 || joysticVertical != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
