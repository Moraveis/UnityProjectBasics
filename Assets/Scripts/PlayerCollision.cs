using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMoviment movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
