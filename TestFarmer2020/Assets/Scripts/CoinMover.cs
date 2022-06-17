using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    [SerializeField]  float spiningSpeed = 120;
    float speed=8;
    Vector3 textCordinats;
    // Start is called before the first frame update
    void Start()
    {
        textCordinats = GameObject.Find("Canvas/CoinsText").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spiningSpeed * Time.deltaTime, 0 );
        transform.position = Vector3.MoveTowards(transform.position, textCordinats, speed*Time.deltaTime);
    }
}
