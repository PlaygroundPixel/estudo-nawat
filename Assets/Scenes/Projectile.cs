using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Scenes
{
    public class Projectile : MonoBehaviour
    {
        public static Rigidbody2D Rigid;
        private Camera _mainCam;
        private Vector3 _mousePos;

        public float maxVelocity = 15f;
        public float speedBall;
        public float force;
        
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            CapVelocity();
        }
        IEnumerator CapVelocity()
        {
            if (Rigid.velocity.magnitude > maxVelocity)
            { 
                Rigid.velocity = Vector3.ClampMagnitude(Rigid.velocity, maxVelocity);
            }
            yield return new WaitForSeconds(0.1f);
        }
        
        


    }
}
