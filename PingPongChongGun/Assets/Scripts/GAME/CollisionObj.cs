using System.Drawing;
using UnityEngine;

public class CollisionObj : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public float GlobalSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void MoveToMousePosition()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 targetPosition = new Vector2(mousePosition.x, mousePosition.y);

        // Move towards the target position with physics
        Vector2 direction = (targetPosition - _rigidBody.position).normalized;
        float speed = GlobalSpeed * 5.0f; // Adjust the speed as needed
        _rigidBody.linearVelocity = direction * speed;
    }

    public void FixedUpdate()
    {
        MoveToMousePosition();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Reducing Velocity/Stopping Object");
        // Stop the movement when a collision is detected
        _rigidBody.linearVelocity = Vector2.zero;
    }
}

public class LaunchBallComponent : MonoBehaviour
{
    public float Speed;
    public GameObject BallGO;

    public void LaunchBall(Vector2 spawnPoint,Vector2 direction)
    {
        Instantiate(BallGO, spawnPoint, Quaternion.identity);
        BallGO.GetComponent<Rigidbody2D>().linearVelocity = direction * Speed;
    }


}