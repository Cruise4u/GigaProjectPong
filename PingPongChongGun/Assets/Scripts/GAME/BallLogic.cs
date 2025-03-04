using UnityEngine;

public class BallLogic : MonoBehaviour
{
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the ball collided with a wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Reflect the ball's velocity based on the collision normal
            Vector2 normal = collision.contacts[0].normal;
            _rb.linearVelocity = Vector2.Reflect(_rb.linearVelocity, normal);
        }
    }
}
