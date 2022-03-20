using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private void Start()
    {
        scoreText.text = string.Format("Score = {0}\nHighscore = {1}", Score.score, PlayerPrefs.GetInt("Highscore"));
    }

}
