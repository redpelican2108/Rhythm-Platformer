using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Transform target;
    public Transform cannon;
    public float distance;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * bulletSpeed * Time.deltaTime;
        if(Vector3.Distance(transform.position,cannon.position) > distance)
        {
            Destroy(gameObject);
        }
    }
}
