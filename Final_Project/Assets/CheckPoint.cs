using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject Player;
    public float time;

    public AudioClip reborn;
    private float r;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        time = 0;
        r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0,0.03f,0);

        if(gameObject.activeSelf == true)
        {
            time += Time.deltaTime;
            if(r == 0)
            {
                AudioSource.PlayClipAtPoint(reborn, transform.localPosition);
                r = 1;
            }
        }

        if (time >= 4)
        {
            time = 0;
            gameObject.SetActive(false);
            r = 0;
        }
    }
}
