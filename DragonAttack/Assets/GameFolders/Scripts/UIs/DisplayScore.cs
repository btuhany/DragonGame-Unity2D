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
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged; //
        }
        private void HandleOnScoreChanged(int score)
        {
            _scoreText.text = "Score: " + score;
        }
    }

}

