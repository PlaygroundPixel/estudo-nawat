using UnityEngine;

namespace Scenes
{
    public class Bloco : MonoBehaviour
    {
        public static int LifeBlock = 30;

        void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject){
                LifeBlock--;
            }
        }
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(LifeBlock == 0){
                Destroy(gameObject);
            }
        }
    }
}
