using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator anim;
    bool isCuttingGrass;
  
    [SerializeField] CuttingGrassButton cutButton;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isCuttingGrass = GetComponent<CuttingGrassButton>().IsCutting;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(GetComponent<PlayerController>().IsRuning()==true)
        {
           
            anim.SetBool("IsRuning", true);
        }
        if (GetComponent<PlayerController>().IsRuning() == false)
        {
           
            anim.SetBool("IsRuning", false);
        }

        isCuttingGrass = cutButton.IsCutting;

        if (isCuttingGrass == true)
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
