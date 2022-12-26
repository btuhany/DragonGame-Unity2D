using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanics
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectile;
        [SerializeField] Transform launchingPosition;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float timeLimit;
        public float _currentTime;
        bool _ableToLaunch = true;
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > timeLimit)
            {
                _ableToLaunch = true;
                _currentTime = 0;
            }
                

        }
        public void LaunchTheProjectile()
        {
            if(_ableToLaunch)
            {
                var currentProjectile = Instantiate(projectile, launchingPosition.position, launchingPosition.rotation);
                currentProjectile.transform.parent = projectileParent.transform;
                _ableToLaunch = false;
            }
            
        }

    }
}

