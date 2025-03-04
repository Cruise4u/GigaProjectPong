using UnityEngine;
using UnityEngine.UI;
using TMPro;
using OOP_Examples;
using System.Collections;

public class AnimalComponent : MonoBehaviour
{
    public bool activateGoodExample;
    public bool activateBadExample;

    public OOPClass.OOPEncapsulationExample.AnimalGoodExample animalGoodExample;

    public float speed;

    public string NewName;

    public void Start()
    {
        animalGoodExample = new OOPClass.OOPEncapsulationExample.AnimalGoodExample();
        StartCoroutine(WalkRoutine(5, 3));
    }

    public void Update()
    {
        //Write WASD Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;

        }
    }

    public IEnumerator WalkRoutine(float seconds, int radius)
    {
        while (true)
        {
            // Calculate a random point within the circular radius
            Vector2 randomPoint = Random.insideUnitCircle * radius;
            Vector3 targetPosition = new Vector3(randomPoint.x, randomPoint.y, transform.position.z);

            // Move to the target position
            while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }

            // Wait for the specified time
            yield return new WaitForSeconds(seconds);
        }
    }




}