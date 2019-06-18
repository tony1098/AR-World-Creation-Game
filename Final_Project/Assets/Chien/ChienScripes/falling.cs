using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gpiont;
    private Rigidbody rb;
    private Collider cl;
    float x, y, z, dem;
    public static bool trapcheckpoint = false;

    void Start()
    {
        trapcheckpoint = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        cl = GetComponent<Collider>();
        cl.isTrigger = true;

        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(5 * x / dem, 5 * y / dem, 5 * z / dem);
    }

    // Update is called once per frame
    void Update()
    {
        if (trapcheckpoint == true)
        {
            cl.isTrigger = false;
            rb.useGravity = true;
        }
        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(5 * x / dem, 5 * y / dem, 5 * z / dem);


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    public static void Trapcheck()
    {
        trapcheckpoint = true;
    }

}
