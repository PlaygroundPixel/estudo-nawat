using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePoint : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
     
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("Player").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        Vector3 rotation = -mousePos - transform.position;
        
        float zRotation = Mathf.Atan2(rotation.x,rotation.y) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(0,0,zRotation);
          
    }
}
