using Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collider)
        {
            
            if(collider.gameObject.tag=="redEnemy")
            {
                Destroy(collider.gameObject);
                GameManager.Instance.AddScore(+5);
            }
            else if(collider.gameObject.tag=="orangeEnemy")
            {
                Destroy(collider.gameObject);
                GameManager.Instance.AddScore(+10);
            }
            else if(collider.gameObject.tag=="enemyProjectile")
            {
                Destroy(collider.gameObject);
            }
                
            Destroy(this.gameObject);
            
        }
        protected override void LifeTimeEnded()
        {
            Destroy(this.gameObject);
        }
    }
}

