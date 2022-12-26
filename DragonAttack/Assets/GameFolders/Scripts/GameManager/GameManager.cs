using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] int totalScore;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;  //Functions can be assigned to this event from
                                                     //another script with OnEnable()
                                                     // + System is a large library it's better to use this way. 
    private void Awake()
    {
        SingletonThisGameObject();
    }
    public void Update()
    {
        
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
