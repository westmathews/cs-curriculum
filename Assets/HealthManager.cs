using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public HUD hud;
    float Timer;

    public float OrigionalTimer = 100;
    // Start is called before the first frame update
    void OnCollisionStay(Collision2D other)
    {
       // if (other.CompareTag("Spikes"))
        {
            Timer -= Time.deltaTime;
            if (Timer < 0) 
             {
                 hud.health = hud.health - 1;
                 Timer = OrigionalTimer;
             }
            
                
            
            if (Timer > 0)
            {
                Timer = Timer - 1;
            }  
        }
    }
    void Start()
    {
        Timer = OrigionalTimer;
        hud.health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
