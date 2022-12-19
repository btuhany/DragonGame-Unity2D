using Abstracts.Spawner;
using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        [SerializeField] EnemyController[] enemies;

        protected override void SpawnRandomEnemy()
        {
            int randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], this.transform);
        }
    }
}

