using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace Scenes
{
    public class Player : MonoBehaviour
    {
        private LineRenderer lr;
        private RaycastHit2D rc;
        public GameObject Projectile;
        private float angle;
        public static Rigidbody2D Rigid;
        public int numBall = 30;
        public bool canShoot;
        int i;

        private void Start()
        {
            lr = gameObject.GetComponent<LineRenderer>();
        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                var position = gameObject.transform.position;
                var right = transform.right;
                rc = Physics2D.Raycast(position,right);
                Debug.DrawRay(position, right * rc.distance, Color.blue);
                lr.SetPosition(0,position);
                lr.SetPosition(1,rc.point);
                Vector2 posi = Vector2.Reflect(new Vector3(rc.point.x , rc.point.y) - this.transform.position, rc.normal);
                lr.SetPosition(2,rc.point + posi.normalized *2);
                Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 dire = Input.mousePosition - pos;
                angle = Mathf.Atan2(dire.y, dire.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            }
            Shoot();

        }

        public void Shoot()
        {
            if (Input.GetMouseButtonUp(0)&& canShoot )
            {
                canShoot = false;
                StartCoroutine(CoroutineShoot());
            }
            
        }

       


        IEnumerator CoroutineShoot()
        {
            for (i = 0; i < numBall; i++)
            {
                yield return new WaitForSeconds(.10f);
                GameObject projectile = Instantiate(Projectile, gameObject.transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody2D>().AddForce(transform.right*1000f);
                
                
            }
        }
        

    }
}