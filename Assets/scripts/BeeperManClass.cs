using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeperManClass : MonoBehaviour
{
    public float beeperSpeed;
    // Start is called before the first frame update
    void Start()
    {
        beeperSpeed = Random.Range(1.0f, 2.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + beeperSpeed * Time.deltaTime, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            beeperSpeed = beeperSpeed * -1;
        }
    }
}
