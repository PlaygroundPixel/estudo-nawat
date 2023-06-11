using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeText : MonoBehaviour
{
    private int numText => Bloco.LifeBlock;

    [SerializeField] TextMeshPro textBlock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBlock.text = "" + numText;
        if( numText == 0){
            Destroy(gameObject);
        }
        
    }
}
