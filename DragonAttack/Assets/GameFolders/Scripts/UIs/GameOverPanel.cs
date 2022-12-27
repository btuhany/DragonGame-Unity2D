using Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] Death playerDeath;
        private void Awake()
        {
            
        }
        private void Start()
        {
            playerDeath.OnDeath += HandleOnDeath;
        }
        private void OnDisable()         
        {
            playerDeath.OnDeath -= HandleOnDeath;
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

