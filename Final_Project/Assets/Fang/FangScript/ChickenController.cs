using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
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
        transform.localPosition = new Vector3(Mathf.PingPong(0.1f * Time.time, 0.4f) - 0.25f, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x >= 0.14f)
        {
            transform.localEulerAngles = new Vector3(0, -90, -90);
        }
        if (transform.localPosition.x <= - 0.24f)
        {
            transform.localEulerAngles = new Vector3(0, 90, 90);
        }
    }
}