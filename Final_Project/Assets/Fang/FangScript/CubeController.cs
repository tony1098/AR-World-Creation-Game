using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rb;
    public GameObject Gpoint;
    float x, y, z, dem;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");

        transform.Translate(Vector3.forward * moveHorizontal * speed * Time.deltaTime);   // 控制移动
        transform.Translate(Vector3.up * jump * speed * Time.deltaTime);   // 控制移动

        x = Gpoint.transform.position.x;
        y = Gpoint.transform.position.y;
        z = Gpoint.transform.position.z;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(1 * x / dem, 1 * y / dem, 1 * z / dem);
    }
}