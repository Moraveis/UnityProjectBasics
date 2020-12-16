using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerScript gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
