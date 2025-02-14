using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Define

    [SerializeField] TMP_Text score_solid;
    [SerializeField] TMP_Text score_fluid;
    [SerializeField] int score = 0;
    public string Main_Game;
    public string Game_Over;


    void Start()
    {
        Score();
    }

    void Update()
    {

    }

    // Score Junk
    public void Score()
    {
        score_fluid.text = score.ToString();
    }

    public void AddScore()
    {
        score += 10;
        Score();
    }
}
