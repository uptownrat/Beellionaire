using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeClass : MonoBehaviour
{
    // make bees bounce back after hitting walls and flip

    public float beeSpeed;
    public int directionType;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
        beeSpeed = Random.Range(1.0f, 2.5f);
        directionType = Random.Range(1, 8);
    }

    // Update is called once per frame
    void Update()
    {
        // decides which direction the bees fly in
        switch(directionType)
        {
            case 1:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y);
                Debug.Log("east, 1");
                break;
            case 2:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y - beeSpeed * Time.deltaTime);
                Debug.Log("southeast, 2");
                break;
            case 3:
                transform.position = new Vector2(transform.position.x, transform.position.y - beeSpeed * Time.deltaTime);
                Debug.Log("south, 3");
                break;
            case 4:
                transform.position = new Vector2(transform.position.x - beeSpeed * Time.deltaTime, transform.position.y - beeSpeed * Time.deltaTime);
                Debug.Log("southwest, 4");
                break;
            case 5:
                transform.position = new Vector2(transform.position.x - beeSpeed * Time.deltaTime, transform.position.y);
                Debug.Log("west, 5");
                break;
            case 6:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y + beeSpeed * Time.deltaTime);
                Debug.Log("northwest, 6");
                break;
            case 7:
                transform.position = new Vector2(transform.position.x, transform.position.y + beeSpeed * Time.deltaTime);
                Debug.Log("north, 7");
                break;
            default:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y + beeSpeed * Time.deltaTime);
                Debug.Log("northeast, 8");
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            Debug.Log("hit wall");
            beeSpeed = beeSpeed * -1;
        }
    }

}
