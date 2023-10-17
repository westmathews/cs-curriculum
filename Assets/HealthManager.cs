using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthManager : MonoBehaviour
{
    public HUD hud;
    float Timer;
    private float Sp;

    public float OrigionalTimer = 1;
    // Start is called before the first frame update
    void OnCollisionStay2D(Collision2D other)
    { 
        if (other.gameObject.CompareTag("Spikes"))
        {
            Timer -= Time.deltaTime;
            if (Timer < 0) 
            {
                hud.health = hud.health - 1;
                Timer = OrigionalTimer;
            }
            
                
            
            if (Timer > 0)
            {
                Timer = Timer - 5;
            }  
        }
    }
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        Timer = 0;
        hud.health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
