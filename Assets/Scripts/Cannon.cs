using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    float counter;
    public GameObject bullet;
    public float timer;
    public Transform targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        counter = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0)
        {
            counter -= Time.deltaTime;
        }
        else
        {
            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            projectile.GetComponent<Bullet>().target = targetPosition;
            projectile.GetComponent<Bullet>().cannon = gameObject.transform;
            counter = timer;
        }
    }
}
