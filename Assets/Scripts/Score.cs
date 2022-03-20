using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static float speedIncrease = 1;
    [SerializeField] private Text scoreText;

    private void Start()
    {
        scoreText.text = "SCORE = " + score.ToString();
    }

    private void Update()
    {
        scoreText.text = "SCORE = " + score.ToString();
    }
}
