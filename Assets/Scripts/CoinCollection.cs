using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    
    public HUD hud;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hud.Coins = hud.Coins + 1;
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        hud.Coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
