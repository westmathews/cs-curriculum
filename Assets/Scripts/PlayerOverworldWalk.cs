using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverworldWalk : MonoBehaviour
{
    private float walkspeed;
    private float xDirection;
    private float xVector;
    private float yDirection;
    private float yVector;
    // Start is called before the first frame update
    void Start()
    {
        walkspeed = 5;

    }

    // Update is called once per frame
    private void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkspeed * Time.deltaTime;
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);

        
    }
}