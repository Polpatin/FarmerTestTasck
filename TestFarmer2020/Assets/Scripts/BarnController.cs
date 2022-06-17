using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnController : MonoBehaviour
{
   
    [SerializeField] GameObject Coin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject .tag=="Hay")
        {
            Destroy(other.gameObject);

            Instantiate(Coin, new Vector3(transform.position.x, transform.position.y, transform.position.z-8f), Quaternion.identity);
        }
    }
}
