using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mechanics;
using Controllers;
namespace Mechanics
{
    public class EnemyProjectile : MonoBehaviour
    {
        
        [SerializeField] EnemyProjectileController projectile;
        [SerializeField] Transform launchingPosition;
        float _timeLimit;
        private float _currentTime;
        bool _ableToLaunch = true;

        private void Start() {
            _timeLimit=Random.Range(0.8f,2.35f);
        }
        private void Update()
        {
            
           _currentTime += Time.deltaTime;
            if (_currentTime > _timeLimit)
            {
                _currentTime = 0;
                 LaunchTheProjectile();
            }
        }
        public void LaunchTheProjectile()
        {
            if(_ableToLaunch)
            {
                _ableToLaunch = false;
                var currentProjectile = Instantiate(projectile, launchingPosition.position, launchingPosition.rotation);
                
                
            }
            
        }
      
    }
}

