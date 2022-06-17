using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiggleHayStack : MonoBehaviour
{


     float speed = 0.09f;

   public bool isMoveRight;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SwitchDirection", 1, 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WiggleLeftToRight();
    }
    void SwitchDirection()
    {
      
        if(isMoveRight==true)
        {
            isMoveRight = false;
            return;
        }
        if(isMoveRight==false)
        {
            isMoveRight = true;
            return;
        }
    }
    void WiggleLeftToRight()
    {
        if (isMoveRight==true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
          
        }
         if (isMoveRight==false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
           
        }
   
    }
}
