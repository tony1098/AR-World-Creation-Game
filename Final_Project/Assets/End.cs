using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private float end,time;
    public GameObject Fire_Work;
    // Start is called before the first frame update
    void Start()
    {
        Fire_Work.SetActive(false);
        end = 0;
        time = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            end = 1;
            Fire_Work.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(end == 1)
        {
            time += Time.deltaTime;
        }

        if (time >= 4)
        {
            time = 0;
            end = 0;
            Fire_Work.SetActive(false);
            SceneManager.LoadScene("End_Scene");
        }
    }
}
