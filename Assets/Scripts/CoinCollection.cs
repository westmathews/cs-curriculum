using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public float Coins;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            Coins = Coins + 1;
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
