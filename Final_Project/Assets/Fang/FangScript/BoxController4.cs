﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.PingPong(0.15f * Time.time, 0.5f) - 0.25f);
    }
}
