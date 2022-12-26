using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstracts;

namespace Controllers
{
    public class EnemyProjectileController : LifeCycleController
    {
        
        private void OnTriggerEnter2D(Collider2D collider)
        {    
            Destroy(this.gameObject);            
        }
          protected override void LifeTimeEnded()
        {
            Destroy(this.gameObject);
        }
    }
}

