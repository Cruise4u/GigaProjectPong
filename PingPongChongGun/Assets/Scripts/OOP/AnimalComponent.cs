using UnityEngine;
using UnityEngine.UI;
using TMPro;
using OOP_Examples;

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






}