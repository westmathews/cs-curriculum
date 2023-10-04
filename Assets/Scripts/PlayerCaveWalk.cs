using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCaveWalk : MonoBehaviour
{
    private float xWalkspeed;
    private float xDirection;
    private float xVector;
    // Start is called before the first frame update
    void Start()
    {
        xWalkspeed = 5;

    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xWalkspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
