using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverPanel;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("game over :(");
            gameObject.GetComponent<PlayerMovement>().canMove = false;
            gameObject.GetComponent<Animator>().Play("Death");
            gameOverPanel.SetActive(true);
            FindObjectOfType<ScoreCounter>()?.ChangeCount();
        }
    }
}
