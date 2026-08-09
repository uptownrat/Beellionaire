using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeClass : MonoBehaviour
{
    // make bees bounce back after hitting walls and flip

    public float beeSpeed;
    Vector2 location;
    public Vector2 velocity;
    public Vector2 acceleration;
    public float accelMult = 10f;

    public float mass = 0.13f;
    public float maxForce = 0.18f;

    float wanderAngle = 0;

    // public int directionType;

    // Start is called before the first frame update
    void Start()
    {
        beeSpeed = 0.2f;
        location = new Vector2(0, 0);
        velocity = new Vector2(0, 0);
        acceleration = new Vector2(0, 0);

        // transform.position = new Vector3(0f, 0f, 0f);
        // directionType = Random.Range(1, 8);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fly();
        location.x = Mathf.Clamp(location.x, -9, 9);
        location.y = Mathf.Clamp(location.y, -5, 5);
        transform.position = location;

        // decides which direction the bees fly in
        /*
        switch(directionType)
        {
            case 1:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y);
                break;
            case 2:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y - beeSpeed * Time.deltaTime);
                break;
            case 3:
                transform.position = new Vector2(transform.position.x, transform.position.y - beeSpeed * Time.deltaTime);
                break;
            case 4:
                transform.position = new Vector2(transform.position.x - beeSpeed * Time.deltaTime, transform.position.y - beeSpeed * Time.deltaTime);
                break;
            case 5:
                transform.position = new Vector2(transform.position.x - beeSpeed * Time.deltaTime, transform.position.y);
                break;
            case 6:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y + beeSpeed * Time.deltaTime);
                break;
            case 7:
                transform.position = new Vector2(transform.position.x, transform.position.y + beeSpeed * Time.deltaTime);
                break;
            default:
                transform.position = new Vector2(transform.position.x + beeSpeed * Time.deltaTime, transform.position.y + beeSpeed * Time.deltaTime);
                break;
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            // beeSpeed = beeSpeed * -1;
        }
    }

    private void fly()
    {
        Vector2 wander = Wander();
        applyForce(wander);

        // acceleration = RandomUnitVector();
        // acceleration = acceleration * accelMult;

        velocity += acceleration;
        velocity = Vector2.ClampMagnitude(velocity, beeSpeed);

        location += velocity;
    }

    private Vector2 RandomUnitVector()
    {
        float random = Random.Range(0f, 260f);
        return new Vector2(Mathf.Cos(random), Mathf.Sin(random));
    }

    private void applyForce(Vector2 force)
    {
        Vector2 f = force / mass;
        acceleration += f;
    }

    private Vector2 Seek(Vector2 target)
    {
        Vector2 desired = target - location;
        desired.Normalize();
        desired = desired * beeSpeed;

        Vector2 steer = desired - velocity;
        steer = Vector2.ClampMagnitude(steer, maxForce);
        return steer;
    }

    private Vector2 Wander()
    {
        float wanderRadius = 25f;         // Radius for our "wander circle"
        float wanderDist = 80f;         // Distance for our "wander circle"
        float change = 0.3f;

        Vector2 prediction = velocity;
        prediction.Normalize();
        prediction = prediction * wanderDist;
        prediction += location;

        wanderAngle += Random.Range(-change, change);

        float currentDirection = Mathf.Atan2(velocity.y, velocity.x);
        float newDirection = currentDirection + wanderAngle;

        float x = wanderRadius * Mathf.Cos(newDirection);
        float y = wanderRadius * Mathf.Sin(newDirection);

        Vector2 targetOffset = new Vector2(x, y);
        Vector2 target = prediction + targetOffset;

        return Seek(target);
    }
}
