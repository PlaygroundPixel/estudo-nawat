using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeText : MonoBehaviour
{
    public int numTextBlock => Bloco.lifeBlock;

    [SerializeField] TextMeshPro textBlock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBlock.text = "" + numTextBlock;
        if( numTextBlock == 0){
            Destroy(gameObject);
        }
        
    }
}
