using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public static int score;

        void Start()
        {
            scoreText.text = "Score : ";
        }

        void Update()
        { 
            scoreText.text = "score : " + score;
            
        }

        
    
}

//réparer score
