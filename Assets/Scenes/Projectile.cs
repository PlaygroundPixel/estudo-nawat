using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rigid;

    public float maxVelocity = 15f;
	public float speedBall;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigid.velocity.magnitude > maxVelocity)
        {
            rigid.velocity = Vector3.ClampMagnitude(rigid.velocity, maxVelocity);
        }
    }
}
