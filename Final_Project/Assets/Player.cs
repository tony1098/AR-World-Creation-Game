using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Player : MonoBehaviour
{
    Rigidbody rBody;
    public float movespeed, jumpspeed;
    private float right;
    private float recX, recY;
    float X, Y, Z;

    public Animator anim;
    AnimatorStateInfo animatorInfo;
    

    public Joystick joystick;

    public Health_Management health_management;

    public AudioClip Jump, Gethealth, Hurt;

    private float ground;
    public float show,hurt;
    private float type;
    private Vector3 gravity;
    private float G_length;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        
        rBody = this.GetComponent<Rigidbody>();

        right = 1;

        show = 0;
        hurt = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        //***** 進入到另一個場景的範圍 *****//
        if (transform.parent != other && other.tag =="Card")
        {
            transform.parent = other.transform;
            rBody.velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.tag == "Heart")
        {
            if (health_management.health < 3)
            {
                health_management.health += 1;
            }
            AudioSource.PlayClipAtPoint(Gethealth, transform.localPosition);
            collision.gameObject.SetActive(false);
        }

        if (collision.transform.tag == "Attack")
        {
            if(hurt == 0)
            {
                AudioSource.PlayClipAtPoint(Hurt, transform.localPosition);
                hurt = 1;
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Field")
        {
            ground = 1;
        }
        if(collision.transform.tag == "PingPong")
        {
            ground = 1;
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Field" || collision.transform.tag == "PingPong")
        {
            ground = 0;
        }
        if(collision.transform.tag == "PingPong")
        {
            transform.parent = collision.transform.parent;
        }
    }

    public void OnBtn()
    {
        if (ground == 1)
        {
            show = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //***** 重力設定 *****//
        if(transform.parent.tag == "PingPong")
        {
            gravity = transform.parent.parent.GetChild(0).position;
        }
        else
        {
            gravity = transform.parent.GetChild(0).position;
        }

        G_length = Mathf.Abs(gravity.x) + Mathf.Abs(gravity.y) + Mathf.Abs(gravity.z);
        
        Physics.gravity = new Vector3(gravity.x/ G_length, gravity.y / G_length, gravity.z / G_length);
        //***** *****//

        //***** 轉向設定 *****//
        if (transform.parent.tag == "PingPong")
        {
            if (right == 1)
            {
                recY = 90;
            }
            if (right == -1)
            {
                recY = -90;
            }
            transform.localEulerAngles = new Vector3(0, recY, 0);
        }
        else
        {
            if (right == 1)
            {
                recX = 0;
            }
            if (right == -1)
            {
                recX = 180;
            }

            transform.localEulerAngles = new Vector3(recX, 180, 90);
        }
        
        //*****

        //***** 位置設定 *****//
        

        if(transform.parent.tag == "PingPong")
        {
            X = transform.localPosition.x;
            Y = transform.localPosition.y;
            transform.localPosition = new Vector3(X, Y, -3.7f);
        }
        else
        {
            X = transform.localPosition.x;
            Z = transform.localPosition.z;
            transform.localPosition = new Vector3(X, 0.15f, Z);
        }
        //***** *****//

        
        if (-0.5 < joystick.Horizontal && joystick.Horizontal < 0.5)
        {
            type = 0;
        }
        if (joystick.Horizontal > 0.5)
        {
            type = 2;
        }
        if (joystick.Horizontal < -0.5)
        {
            type = 1;
        }

        if (type == 1)
        {
            right = -1;
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime , Space.Self);
        }
        if (type == 2)
        {
            right = 1;
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }

        if (show == 0 && hurt == 0)
        {
            if (type == 0)
            {
                anim.Play("idle");
            }
            if (type == 1 || type == 2)
            {
                anim.Play("walk");
            }

        }
        if (show == 1 && hurt == 0)
        {
            anim.Play("show");
            animatorInfo = anim.GetCurrentAnimatorStateInfo(0);
            if ((animatorInfo.no​​rmalizedTime > 0.5f) && (animatorInfo.IsName("show")))//normalizedTime：0-1在播放、 0開始、1結束MyPlay為狀態機動畫的名字
            {
                show = 0;
                AudioSource.PlayClipAtPoint(Jump, transform.localPosition);
                rBody.AddRelativeForce(0, jumpspeed * Time.deltaTime, 0);
                
            }
        }
        if(hurt == 1)
        {
            anim.Play("hurt");
            
            animatorInfo = anim.GetCurrentAnimatorStateInfo(0);
            if ((animatorInfo.no​​rmalizedTime > 1f) && (animatorInfo.IsName("hurt")))//normalizedTime：0-1在播放、 0開始、1結束MyPlay為狀態機動畫的名字
            {
                hurt = 0;
                
                transform.position = new Vector3(0, -10, 0);

            }   
        }

    }
}
