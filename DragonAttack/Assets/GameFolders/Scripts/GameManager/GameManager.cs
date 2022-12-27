using System;
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
            else if (totalScore > 350)
            {
                Time.timeScale = 1.8f;
            }
            else if (totalScore > 250)
            {
                Time.timeScale = 1.6f;
            }
            else if (totalScore > 170)
            {
                Time.timeScale = 1.4f;
            }
            else if (totalScore > 100)
            {
                Time.timeScale = 1.2f;
            }
            else if (totalScore > 60)
            {
                Time.timeScale = 1.1f;
            }
        }
        
    }


    public void StartGame()
    {
        totalScore = 0;
        Time.timeScale = 1f;
       StartCoroutine(StartGameAsync());
    }
    
    private IEnumerator StartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
