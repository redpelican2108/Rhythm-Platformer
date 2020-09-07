using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform position1, position2;
    public bool movingToLeft;
    public float speed;
    Vector3 nextPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (movingToLeft)
        {
            nextPosition = position1.position;
        }
        else
        {
            nextPosition = position2.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == position1.position)
        {
            nextPosition = position2.position;
        }

        if (transform.position == position2.position)
        {
            nextPosition = position1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);

    }
}
