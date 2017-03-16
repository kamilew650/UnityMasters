using UnityEngine;
using System.Collections;

public class Move_Boss : MonoBehaviour
{

    public float maxSpeed = 10;
    public float leftRightSpeed = 0.01f;
    private float speed = 2;


    void start()
    {
        speed = leftRightSpeed;
    }

    void Update()
    {
        if (transform.position.y > 4)
        {
            transform.Translate(new Vector3(0, maxSpeed * Time.deltaTime, 0));
        }
        else
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            if (transform.position.x < -3)
            {
                speed = -2;
            }
            if (transform.position.x > 3)
            {
                speed = 2;
            }
         
        }
    }


}
