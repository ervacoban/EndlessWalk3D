using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void PlayLevel()
    {
        Score.score = 0;
        Score.speedIncrease = 1;
        SceneManager.LoadScene("Level");
    }

    public static void GameOver()
    {
        if (Score.score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", Score.score);
        }
        SceneManager.LoadScene("GameOver");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
