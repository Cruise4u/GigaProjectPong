using System.Collections;
using UnityEngine;

public class CannonRaycast : MonoBehaviour
{
    public GameObject BallGO;
    public float BallSpeed;

    // Reference to child object
    private GameObject aimSightGO;
    private Vector2 _aimDirection;

    private float radius;

    // Top : 60
    // Bottom : 180
    // Center mid : 120

    [Range(-180, 180)]
    [SerializeField]
    private float desiredAngle;

    public float DesiredAngle
    {
        get { return desiredAngle; }
        set { desiredAngle = Mathf.Clamp(value, -180.0f, 180.0f); }
    }

    private float _previousAngle;



    void Start()
    {
        aimSightGO = transform.GetChild(0).gameObject;
        SetAimSightDirection();
        radius = Vector2.Distance(transform.position, aimSightGO.transform.position);
        _previousAngle = desiredAngle;
    }

    void Update()
    {
        if (Mathf.Abs(desiredAngle - _previousAngle) > Mathf.Epsilon)
        {
            SetAimSightDirection();
            SetAngleDirection(desiredAngle);
            _previousAngle = desiredAngle;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall(_aimDirection);
        }
    }

    void SetAngleDirection(float angle)
    {
        Vector2 desiredDirection = GetPointOnCircle(angle);
        RotateTowardsDirection(_aimDirection, desiredDirection);
    }

    void RotateTowardsDirection(Vector2 a, Vector2 b)
    {
        Vector2 direction = (b - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle < 0 ? angle + 360 : angle);

    }

    Vector2 GetPointOnCircle(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        return new Vector2(transform.position.x + radius * Mathf.Cos(radian), transform.position.y + radius * Mathf.Sin(radian));
    }

    void SetAimSightDirection()
    {
        _aimDirection = (aimSightGO.transform.position - transform.position).normalized;
    }

    public void ShootBall(Vector2 spawnPoint)
    {
        GameObject ball = Instantiate(BallGO, transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().linearVelocity = _aimDirection * 10;
    }






}


public class LaunchBallComponent : MonoBehaviour
{
    public float Speed;
    public GameObject BallGO;

    public void LaunchBall(Vector2 spawnPoint, Vector2 direction)
    {
        Instantiate(BallGO, spawnPoint, Quaternion.identity);
        BallGO.GetComponent<Rigidbody2D>().linearVelocity = direction * Speed;
    }


}