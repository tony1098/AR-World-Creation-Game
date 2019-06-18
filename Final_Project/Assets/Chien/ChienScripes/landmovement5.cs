using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landmovement5 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.PingPong(0.1f * Time.time, 0.3f) + 0.055f, transform.localPosition.y, transform.localPosition.z);
        //Invoke("Updownmovement", 1f);
    }
}
