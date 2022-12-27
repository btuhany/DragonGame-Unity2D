using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanics
{
    public class Death : MonoBehaviour
    {
        public bool IsDead;
        public event System.Action OnDeath;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!(collision.gameObject.tag == "UpperBoundary"))
            {
                OnDeath?.Invoke();
                IsDead=true;
                GameManager.Instance.gameOver = true;
                Time.timeScale = 0f;
            }


        }
    }
}

