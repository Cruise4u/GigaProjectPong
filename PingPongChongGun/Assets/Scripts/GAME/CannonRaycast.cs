using System.Collections;
using UnityEngine;

public class CannonRaycast : MonoBehaviour
{
    // Reference to child object
    public GameObject aimSightGO;
    private Vector2 _aimDirection;

    public float radius;

    [Range(0, 360)]
    [SerializeField]
    private float desiredAngle;

    public float DesiredAngle
    {
        get { return desiredAngle; }
        set { desiredAngle = Mathf.Clamp(value, 0f, 360f); }
    }

    void Start()
    {
        aimSightGO = transform.GetChild(0).gameObject;
        radius = Vector2.Distance(transform.position, aimSightGO.transform.position);
    }

    void Update()
    {
        SetAimSightDirection();
        SetAngleDirection(DesiredAngle);
    }

    void SetAngleDirection(float angle)
    {
        if (angle != 0)
        {
            Vector2 desiredDirection = GetPointOnCircle(angle);
            RotateTowardsDirection(_aimDirection, desiredDirection);
        }
    }

    void RotateTowardsDirection(Vector2 a, Vector2 b)
    {
        float crossProduct = a.x * b.y - a.y * b.x;
        float angle = Mathf.Atan2(crossProduct, Vector2.Dot(a, b)) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle < 0 ? angle + 360 : angle);
    }

    Vector2 GetPointOnCircle(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        return new Vector2(radius * Mathf.Cos(radian), radius * Mathf.Sin(radian));
    }

    void SetAimSightDirection()
    {
        _aimDirection = (aimSightGO.transform.position - transform.position).normalized;
    }










}
