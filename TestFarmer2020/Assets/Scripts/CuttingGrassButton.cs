using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CuttingGrassButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject Sickle;
    bool isCutting=false;
  
    
    public bool IsCutting
    {
        get { return isCutting; }
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Sickle.SetActive(true);
            isCutting = true;

            
        }
       if (Input.GetKeyUp(KeyCode.Space))
        {

            isCutting = false;
           
            Sickle.SetActive(false);
        }

    }
    //public void CutTheGrass()
    //{
    //    isCutting = true;
    //    Sickle.SetActive(true);


    //}
    public void OnPointerDown(PointerEventData eventData)
    {
        Sickle.SetActive(true);
        isCutting = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {

        isCutting = false;

        Sickle.SetActive(false);
    }

}
