using UnityEngine;
using System.Collections;

public class Move_Boss : MonoBehaviour
{

    public float maxSpeed = 10;


    void Update()
    {
        if (transform.position.y > 4)
        {
            transform.Translate(new Vector3(0, maxSpeed * Time.deltaTime, 0));
        }
        else
        {
            transform.Translate(0.1f , 0, 0);
        }
    }


}
