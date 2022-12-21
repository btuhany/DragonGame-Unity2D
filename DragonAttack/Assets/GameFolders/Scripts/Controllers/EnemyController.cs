using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstracts;

namespace Controllers
{
    public class EnemyController : LifeCycleController
    {
        [SerializeField] public bool isNotAnObstacle;

        Rigidbody2D rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        protected override void LifeTimeEnded()
        {
            if(!(isNotAnObstacle))
            {
                GameManager.Instance.AddScore(5);
            }
            Destroy(this.gameObject);
        }

    }
}

