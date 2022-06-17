using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardAnimationControll : MonoBehaviour
{
    Animator anim;
    bool isCuttingGrass;
    [SerializeField] CuttingGrassButton cutButton;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // isCuttingGrass = GetComponent<CuttingGrassButton>().IsCutting;

        isCuttingGrass = cutButton.IsCutting;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0)
        {
            // print(horizontalInput + " " + verticalInput);
            anim.SetBool("IsRuning", true);
        }
        if (verticalInput != 0)
        {
            print(horizontalInput + " " + verticalInput);
            anim.SetBool("IsRuning", true);
        }
        if (verticalInput == 0 & verticalInput == 0)
        {
            anim.SetBool("IsRuning", false);
        }
        if (isCuttingGrass==true)
        {
            anim.SetBool("IsCutting", true);
            anim.SetBool("IsRuning", false);
           
        }
        if (isCuttingGrass == false)
        {
            anim.SetBool("IsCutting", false);
        }
       
    }
}
