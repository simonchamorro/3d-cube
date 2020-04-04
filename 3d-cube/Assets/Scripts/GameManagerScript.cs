using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    public void EndGame()
    {   
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
