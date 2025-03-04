using UnityEngine;

public class PaddleLogic : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rb;
    private float directionScaling;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        directionScaling = 0;
    }   


    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    directionScaling = Time.deltaTime * speed;
        //    if (transform.position.y < 2.9f)
        //    {
        //        transform.position += new Vector3(0, directionScaling, 0);
        //    }
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    directionScaling = Time.deltaTime * speed;
        //    if (transform.position.y > -2.9f)
        //    {
        //        transform.position -= new Vector3(0, directionScaling, 0);
        //    }
        //}
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            directionScaling = Time.deltaTime * speed;
            if (transform.position.y < 2.9f)
            {
                transform.position += new Vector3(0, directionScaling, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionScaling = Time.deltaTime * speed;
            if (transform.position.y > -2.9f)
            {
                transform.position -= new Vector3(0, directionScaling, 0);
            }
        }

























        //if(transform.position.y > 2.5f)
        //{

        //}



        //if (Input.GetKey(KeyCode.W))
        //{
        //    //Debug.Log("Button being pressed!");
        //    if (transform.position.y < 2.9f)
        //    {
        //        Debug.Log("Adding force to paddle!");
        //        PhysicsMoveVertically(_rb, speed);
        //    }
        //    else
        //    {
        //        _rb.linearVelocity = new Vector2(0, 0);
        //    }
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    if (transform.position.y > -2.9f)
        //    {
        //        PhysicsMoveVertically(_rb, speed);
        //    }
        //    else
        //    {
        //        _rb.linearVelocity = new Vector2(0, 0);
        //    }
        //}
    }

    //public void PhysicsMoveVertically(Rigidbody2D rb, float force)
    //{
    //    rb.AddForceY(force, ForceMode2D.Impulse);
    //}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {

        }
    }
}

