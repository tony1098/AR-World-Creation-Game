using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_Management : MonoBehaviour
{
    public float health;

    public GameObject heart1, heart2, heart3;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        
    }

    private void Awake()
    {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Fail_Scene");
        }

        if(health >= 1)
        {
            heart1.SetActive(true);
        }
        else
        {
            heart1.SetActive(false);
        }

        if (health >= 2)
        {
            heart2.SetActive(true);
        }
        else
        {
            heart2.SetActive(false);
        }

        if (health >= 3)
        {
            heart3.SetActive(true);
        }
        else
        {
            heart3.SetActive(false);
        }


    }
}
