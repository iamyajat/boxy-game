using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerMovement movement;
    public float endCollision = 1000f;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Score>().enabled = false;

        }
    }

}
