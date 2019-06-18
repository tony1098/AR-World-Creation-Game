using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmovement7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0.1f - Mathf.PingPong(0.1f * Time.time, 0.2f)  );
    }

}
