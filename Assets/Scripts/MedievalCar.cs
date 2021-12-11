using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedievalCar : MonoBehaviour
{
    public LevelManager lm;

    public Lever forward;

    public Lever vertical;


    public float speed = 5f;
    public Transform Up;
    public Transform Down;
    public Transform FORWARD;

    public Vector2 position;

    public new Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (forward.lever)
        {
            transform.position = Vector2.MoveTowards(transform.position, FORWARD.position, step);
            //rigidbody2D.velocity = new Vector2(speed, 0);
            //transform.position = new Vector3(transform.position.x + speed, transform.position.y,transform.position.z);
        }
        else
        {
            if (vertical.lever)
            {
                transform.position = Vector2.MoveTowards(transform.position, Up.position, step);
                //rigidbody2D.velocity = new Vector2(0, speed);
                //transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, Down.position, step);
                //rigidbody2D.velocity = new Vector2(0, -1 *speed);
                //transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }
        }
    }
}
