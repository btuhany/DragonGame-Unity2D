using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstracts.Spawner
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)][SerializeField] float maxSpawnTime = 3f;
        [Range(0.2f, 2f)][SerializeField] float minSpawnTime = 1f;

        float _currentSpawnerTime;
        float _randomSpawnTime;
        private void Start()
        {
            ResetTimerAndGetRandomSpawnTime();
        }
        private void Update()
        {
            _currentSpawnerTime += Time.deltaTime;

            if (_currentSpawnerTime > _randomSpawnTime)
            {
                SpawnRandomEnemy();
                ResetTimerAndGetRandomSpawnTime();
            }
        }

        protected abstract void SpawnRandomEnemy();
        

        private void ResetTimerAndGetRandomSpawnTime()
        {
            _currentSpawnerTime = 0f;
            _randomSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

