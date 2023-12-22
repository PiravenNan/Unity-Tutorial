using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //added

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] TextMeshProUGUI coinsText; //added
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins +=1;
            coinsText.text = "Coins: " + coins; //added
        }
    }
}


