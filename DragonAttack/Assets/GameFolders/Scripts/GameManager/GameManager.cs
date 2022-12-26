using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] int totalScore;
    
    public bool gameOver=false;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;  //Functions can be assigned to this event from
                                                     //another script with OnEnable()
                                                     // + System is a large library it's better to use this way. 
    private void Awake()
    {
        SingletonThisGameObject();
    }
    
    public void SingletonThisGameObject()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void AddScore(int score)
    {
        totalScore += score;
        OnScoreChanged?.Invoke(totalScore); //trigger the event
        //if(OnScoreChanged != null)
        //{
        //    OnScoreChanged();
        //}
        CheckScoreAndAdjustDifficulty(totalScore);
    }
    private void CheckScoreAndAdjustDifficulty(int totalScore)
    {
        if(!gameOver)
        {
            if (totalScore > 650)
            {
                Time.timeScale = 2f;
            }
            else if (totalScore > 450)
            {
                Time.timeScale = 1.8f;
            }
            else if (totalScore > 350)
            {
                Time.timeScale = 1.7f;
            }
            else if (totalScore > 200)
            {
                Time.timeScale = 1.5f;
            }
            else if (totalScore > 130)
            {
                Time.timeScale = 1.3f;
            }
            else if (totalScore > 90)
            {
                Time.timeScale = 1.2f;
            }
        }
        
    }


    public void RestartGame()
    {
        totalScore = 0;
        Time.timeScale = 1f;
       StartCoroutine(RestartGameAsync());
    }
    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
