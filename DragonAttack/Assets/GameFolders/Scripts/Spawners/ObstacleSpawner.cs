using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawners
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [Range(2f, 5f)][SerializeField] float maxSpawnTime = 3f;
        [Range(0.2f, 2f)][SerializeField] float minSpawnTime = 1f;

        [SerializeField] EnemyController enemy;

        float _currentSpawnerTime;
        float _randomSpawnTime;
        private void Awake()
        {
            _randomSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
        private void Update()
        {
            _currentSpawnerTime += Time.deltaTime;

            if (_currentSpawnerTime > _randomSpawnTime)
            {
                Spawn();
                _currentSpawnerTime = 0f;
                _randomSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            }
        }

        private void Spawn()
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}

