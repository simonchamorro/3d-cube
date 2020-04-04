using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerScript gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
