using Abstracts.Spawner;
using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawners
{
    public class RedEnemySpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void SpawnRandomEnemy()
        {
           
            var newEnemy = Instantiate(enemy,RandomYPosition(),this.transform.rotation);
            newEnemy.transform.parent = this.transform;
        }
        private Vector2 RandomYPosition()
        {
            Vector2 spawnPosition = new Vector2();
            spawnPosition += new Vector2(this.transform.position.x, transform.position.y + Random.Range(-4f, 4f));
            return spawnPosition;
        }
      
    }
}

