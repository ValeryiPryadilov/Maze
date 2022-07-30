using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{


    public class GoodBonus : Bonus, IFly, IFlick
    {
        private float hightFly;
        private float intensFlick;

        private void Awake()
        {
            hightFly = Random.Range(1f, 7f);
            intensFlick = Random.Range(1f, 5f);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, hightFly), transform.position.z);
        }

        public void Flick()
        {
            //делаем рандомное сияние обьекта , можно через интенсивность 
        }

        void Update()
        {
            Fly();
            Flick();
        }
    }
}
