using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemovement : MonoBehaviour
{
    public GameObject imagepos;
    public GameObject Gpiont;
    public static bool checkpiont = false;
    public float speed = 2.5f;
    float x, y, z,dem;
    private Rigidbody rb;
    bool checksound1 = false;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 startpos =  imagepos.transform.position;
        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;

        dem = Mathf.Sqrt(x * x + y * y + z * z);
        Physics.gravity = new Vector3(5 * x / dem, 5 * y / dem, 5 * z / dem);


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //rb.AddRelativeForce(Vector3.forward*speed);

        if (h!= 0 || v!= 0)
        {
            transform.Translate(Vector3.forward * v * speed * Time.deltaTime);   // 控制移动
            transform.Rotate(Vector3.up * h * speed * 100 * Time.deltaTime);
            if (checksound1 == false)
            {
                checksound1 = true;
                grassmanerger.grasssound();
                Invoke("soundmanerger", 1f);
            }

            
        }
        else 
        {

        }

        x = Gpiont.transform.position.x;
        y = Gpiont.transform.position.y;
        z = Gpiont.transform.position.z;


        dem = Mathf.Sqrt(x * x + y * y + z * z);

        Physics.gravity = new Vector3(5*x/dem,5*y/dem, 5*z/dem);


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trap"))
        {
            other.gameObject.SetActive(false);
            falling.Trapcheck();
        }
    }

    void soundmanerger()
    {
        checksound1 = false;
    }
}
