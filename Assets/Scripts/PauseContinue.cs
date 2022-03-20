using UnityEngine;

public class PauseContinue : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject pauseButton;
    private bool paused;

    void Start()
    {
        paused = false;
    }

    void Update()
    {
        if (paused) Time.timeScale = 0;
        else Time.timeScale = 1;
    }

    public void PauseGame()
    {
        paused = true;
        continueButton.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        paused = false;
        continueButton.SetActive(false);
        pauseButton.SetActive(true);
    }
}