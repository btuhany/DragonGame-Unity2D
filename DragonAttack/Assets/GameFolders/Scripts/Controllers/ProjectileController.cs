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
            EnemyController enemy = collider.GetComponent<EnemyController>();
            if(enemy.tag=="redEnemy")
                Destroy(collider.gameObject);
            Destroy(this.gameObject);
            
        }
    }
}

