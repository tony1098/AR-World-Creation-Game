using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landmovement3 : MonoBehaviour
{
    public float speed;
    public Vector3 start_position;
    public Vector3 Length;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        X = Mathf.PingPong(speed * Time.time, Length.x) + start_position.x;
        Y = Mathf.PingPong(speed * Time.time, Length.y) + start_position.y;
        Z = Mathf.PingPong(speed * Time.time, Length.z) + start_position.z;

        transform.localPosition = new Vector3(X, Y, Z);
    }
}
