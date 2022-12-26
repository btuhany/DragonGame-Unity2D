using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanics
{
    public class Death : MonoBehaviour
    {
        [SerializeField] private bool _isDead;
        public bool IsDead { get; set; }
        public event System.Action OnDeath;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!(collision.gameObject.tag == "UpperBoundary"))
            {
                _isDead = true;
                OnDeath?.Invoke();
                Time.timeScale = 0f;
            }


        }
    }
}

