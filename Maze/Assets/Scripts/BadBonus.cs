using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{


    public class BadBonus : Bonus, IFly, IRotation
    {
        private float hightFly;
        private float speedRotate;

        private void Awake()
        {
            hightFly = Random.Range(1f, 3f);
            speedRotate = Random.Range(13f, 40f);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, hightFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotate), Space.World);
        }

        private void Update()
        {
            Fly();
            Rotate();
        }
    }
}
