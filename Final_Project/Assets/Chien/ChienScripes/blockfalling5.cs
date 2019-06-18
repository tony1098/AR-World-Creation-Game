using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockfalling5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gpiont;
    private Rigidbody rb;
    float x, y, z, dem;
    public static bool blockcheckpoint = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        blockcheckpoint = false;
        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;
        rb.isKinematic = true;
        rb.useGravity = false;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(5 * x / dem, 5 * y / dem, 5 * z / dem);
    }

    // Update is called once per frame
    void Update()
    {
        if (blockcheckpoint == true)
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
}
