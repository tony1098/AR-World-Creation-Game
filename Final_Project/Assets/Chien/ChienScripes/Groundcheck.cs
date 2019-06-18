using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gpiont;
    private Rigidbody rb;
    float x, y, z, dem;
    public static bool Groundcheckpoint = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Groundcheckpoint = false;

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
            landmovement2.allobjectcheckpoint = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Groundcheckpoint == true)
        {
            rb.isKinematic = false;
            rb.useGravity = true;

        }

        
        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(5 * x / dem, 5 * y / dem, 5 * z / dem);


    }

    // Update is called once per frame
    

}
