using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    Vector3 start;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.PingPong(0.05f * Time.time, 0.17f) + 0.15f, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x >= 0.31f)
        {
            transform.localEulerAngles = new Vector3(0, -90, -90);
        }
        if (transform.localPosition.x <= 0.16f)
        {
            transform.localEulerAngles = new Vector3(0, 90, 90);
        }
    }
}
