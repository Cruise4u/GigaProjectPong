using UnityEngine;

public class CollisionCheck : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}
