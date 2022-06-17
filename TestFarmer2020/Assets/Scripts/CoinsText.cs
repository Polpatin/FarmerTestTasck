using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinsText : MonoBehaviour
{
    int coinAmount;
    int displayCoin;
    public TextMeshProUGUI coinsText;
    float vibrationLenth=0.2f;
    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = "Coins: ";
        InvokeRepeating("MoneyComparing", 1, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: "+displayCoin;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Coin")
        {
            Destroy(other.gameObject);
            coinAmount += 15;
            
        }
    }
    void MoneyComparing()
    {
        if(coinAmount>displayCoin)
        {
           // TextVibration();
            displayCoin++;
        }
    }
    //void TextVibration()
    //{
    //    transform.position = new Vector3(transform.position.x + vibrationLenth, transform.position.y, transform.position.z);
    //    vibrationLenth = vibrationLenth * -1;
    //}
   
}
