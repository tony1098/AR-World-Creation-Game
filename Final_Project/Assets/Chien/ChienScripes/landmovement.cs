using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landmovement : MonoBehaviour
{
    private Vector3 nextpos;
    // Start is called before the first frame update
    void Start()
    {
        nextpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.PingPong(0.05f * Time.time, 0.2f)-0.134f, transform.localPosition.y, transform.localPosition.z) ;
        //Invoke("Updownmovement", 1f);
    }
    
    /*void Updownmovement()
    {
        transform.localPosition = nextpos + transform.localPosition;
        CancelInvoke("Updownmovement");
    }
    */
}
