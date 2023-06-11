using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject)
        {
            Debug.Log("trigou");
        }
    }
}
