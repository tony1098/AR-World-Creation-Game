using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassmanerger : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip dingclip;
    static AudioSource ding;
    void Start()
    {

        dingclip = Resources.Load<AudioClip>("grasssound");//sound
        ding = GetComponent<AudioSource>();

    }

    public static void grasssound()
    {
        ding.PlayOneShot(dingclip);
    }

}
