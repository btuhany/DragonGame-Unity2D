using Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class ProjectileController : LifeCycleController
    {
        [SerializeField] GameObject redEnemyParticleAndSound;
        [SerializeField] GameObject orangeEnemyParticleAndSound;
        [SerializeField] GameObject fireballParticleAndSound;
        [SerializeField] GameObject efxPosition;
        private void OnTriggerEnter2D(Collider2D collider)
        {
            
            if(collider.gameObject.tag=="redEnemy")
            {
                GameManager.Instance.AddScore(+5);
                Instantiate(redEnemyParticleAndSound,efxPosition.transform.position,efxPosition.transform.rotation);
                Destroy(collider.gameObject);
                
                
            }
            else if(collider.gameObject.tag=="orangeEnemy")
            {
                GameManager.Instance.AddScore(+10);
                Instantiate(orangeEnemyParticleAndSound,efxPosition.transform.position,efxPosition.transform.rotation);
                Destroy(collider.gameObject);
                
            }
            else if(collider.gameObject.tag=="enemyProjectile")
            {
                Instantiate(fireballParticleAndSound,efxPosition.transform.position,efxPosition.transform.rotation);
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

