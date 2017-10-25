using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private Text textScore;

    // Use this for initialization

     void Awake()
    {
        MakeInstance();
    }
    void Start()

    {
       
      
    }

    void MakeInstance()
    {
        if (instance == null) 
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void ReplayButton()
    {

              Application.LoadLevel("Main");
              Time.timeScale = 1;
        
    }
   
    public void GameOverShow()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

}