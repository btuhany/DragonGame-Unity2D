using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UIs
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }
        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;  //we add the function that we should run to
                                                                          //event thus, game manager can run this function.
            HandleOnScoreChanged();          //to view the score as 0 initally
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged; //
        }
        private void HandleOnScoreChanged(int score = 0)
        {
            _scoreText.text = "Score: " + score;
        }
    }

}

