using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int lives = 3;

    public static int bricksDestroyed;
    public int goal;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI LivesText;

    public GameObject winScreen;
    public GameObject loseScreen;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE: " + score;
        LivesText.text = "LIVES: " + lives;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
        }

        if (bricksDestroyed == goal)
        {
            winScreen.SetActive(true);
        }
    }




}
