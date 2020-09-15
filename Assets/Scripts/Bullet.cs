using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject target;
    public GameObject cannon;
    public float distance;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = target.position - position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * bulletSpeed * Time.deltaTime;
        if(Vector3.Distance(position,cannon.position) > distance)
        {
            Destroy(gameObject);
        }
    }
}
