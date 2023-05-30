using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public static int lifeBlock = 30;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject){
            lifeBlock--;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeBlock == 0){
            Destroy(gameObject);
        }
    }
}
