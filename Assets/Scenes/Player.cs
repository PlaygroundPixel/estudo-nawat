using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speedPlayer;
    float dirX, dirY;
    
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
          
    }

    void FixedUpdate()
    {
        rig.velocity = new Vector2(dirX * speedPlayer , dirY * speedPlayer);
    }
}
