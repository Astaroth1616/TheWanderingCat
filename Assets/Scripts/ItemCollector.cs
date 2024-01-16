using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int itemCollected = 0;

    [SerializeField] private Text luckyCoinText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LuckyCoin"))
        {
            Destroy(collision.gameObject);
            itemCollected++;
            Debug.Log("Lucky Coins: " + itemCollected);

            luckyCoinText.text = "Lucky Coins: " + itemCollected;
        }
    }
}
