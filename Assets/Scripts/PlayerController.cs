using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameManager.PlayerDied();
        }
    }
}