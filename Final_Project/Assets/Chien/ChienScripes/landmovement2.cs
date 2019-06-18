using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landmovement2 : MonoBehaviour
{
    // Start is called before the first frame update
    bool shakecheckpoint = false;
    public static bool allobjectcheckpoint = false;

    public  GameObject text1;
    public  GameObject text2;
    public  GameObject text3;

    // Start is called before the first frame update
    void Start()
    {
        shakecheckpoint = false;
        allobjectcheckpoint = false;
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (allobjectcheckpoint == true)
        {
            Controllallobject();
        }
        if (shakecheckpoint == true)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.PingPong(0.5f * Time.time, 0.02f) -0.371f);
        }

    }

    void Controllallobject()
    {

            shakecheckpoint = true;
            allobjectcheckpoint = false;
            Invoke("Turnontext3", 0f);
            Invoke("Turnontext2", 1f);
            Invoke("Turnontext1", 2f);
            Invoke("fallcontroller0", 1f);
            Invoke("fallcontroller1", 2f);
            Invoke("fallcontroller2", 2.5f);
            Invoke("fallcontroller3", 2.5f);
            Invoke("fallcontroller4", 3f);
            Invoke("fallcontroller5", 3f);
            Invoke("fallcontroller6", 1f);
            Invoke("fallcontroller7", 1.5f);
            Invoke("fallcontroller8", 2.5f);
            Invoke("fallcontroller9", 3f);
            Invoke("fallGround", 3.25f);
    }

    void fallGround()
    {
        shakecheckpoint = false;
        
        Groundcheck.Groundcheckpoint = true;
        CancelInvoke("fallGround");
    }

    void fallcontroller0()
    {
        blockfalling0.blockcheckpoint = true;
        CancelInvoke("fallcontroller0");
    }

    void fallcontroller1()
    {
        blockfalling1.blockcheckpoint = true;
        CancelInvoke("fallcontroller1");
    }

    void fallcontroller2()
    {
        blockfalling2.blockcheckpoint = true;
        CancelInvoke("fallcontroller2");
    }

    void fallcontroller3()
    {
        blockfalling3.blockcheckpoint = true;
        CancelInvoke("fallcontroller3");
    }

    void fallcontroller4()
    {
        blockfalling4.blockcheckpoint = true;
        CancelInvoke("fallcontroller4");
    }

    void fallcontroller5()
    {
        blockfalling5.blockcheckpoint = true;
        CancelInvoke("fallcontroller5");
    }

    void fallcontroller6()
    {
        blockfalling6.blockcheckpoint = true;
        CancelInvoke("fallcontroller6");
    }

    void fallcontroller7()
    {
        blockfalling7.blockcheckpoint = true;
        CancelInvoke("fallcontroller7");

    }

    void fallcontroller8()
    {
        blockfalling8.blockcheckpoint = true;
        CancelInvoke("fallcontroller8");
    }

    void fallcontroller9()
    {
        blockfalling9.blockcheckpoint = true;
        text1.SetActive(false);
        CancelInvoke("fallcontroller9");
    }

    void Turnontext1()
    {
        text3.SetActive(false);
        text2.SetActive(false);
        text1.SetActive(true);

        CancelInvoke("Turnontext1");
    }

    void Turnontext2()
    {
        text3.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(true);

    
        CancelInvoke("Turnontext2");
    }

    void Turnontext3()
    {
        text2.SetActive(false);
        text1.SetActive(false);
        text3.SetActive(true);
        CancelInvoke("Turnontext3");
    }

}
