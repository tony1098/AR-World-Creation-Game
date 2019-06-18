using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController2 : MonoBehaviour
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
        transform.localPosition = new Vector3(Mathf.PingPong(0.15f * Time.time, 0.3f) + 0.1f, transform.localPosition.y, transform.localPosition.z);
    }
}
