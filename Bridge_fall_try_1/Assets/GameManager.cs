using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completelevelUi;
    public GameObject RetrylevelUi;
    public void EndGame()
    {
        completelevelUi.SetActive(true);
    }

    public void RetryScreen()
    {
        RetrylevelUi.SetActive(true);
    }
    public void NextGame()
    {
        NextLevel();
    }

    public void RestartGame()
    {
        RestartLevel();
    }

    void NextLevel()
    {
        print("entered game manager");
        SceneManager.LoadScene("level2");
    }

    void RestartLevel()
    {
        print("Restarted level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
