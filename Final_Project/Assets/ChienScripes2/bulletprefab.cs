using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprefab : MonoBehaviour
{
    public static Vector3 bulletposition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        /*
        if (other.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (other.transform.tag == "Field")
        {
            Destroy(gameObject);
        }
        if (other.transform.tag == "PingPong")
        {
            Destroy(gameObject);
        }
        */

        bulletposition = transform.position;
        Firebullet.explosionCheck = true;
        Destroy(gameObject);
    }
}
