using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;
    void Update()
    {
        livesText.text = "Lives : " + lives;
        scoreText.text = "Score : " + score;

        var count = FindObjectsOfType<Brick>().Length;
        if (count <= 0)
        {
            winScreen.SetActive(true);
            enabled = false;
        }

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            enabled = false;
        }
    }
}