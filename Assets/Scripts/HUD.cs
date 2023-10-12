using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int Coins;
    public int health;
    public TextMeshProUGUI HealthText;
    

    public TextMeshProUGUI CoinsText;

    
    // Start is called before the first frame update
    

    void Start()
    {
        
    }






    // Update is called once per frame
    void Update()
    {
        CoinsText.text = Coins.ToString();
        HealthText.text = health.ToString();
    }
}
