using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reborn_Place2 : MonoBehaviour
{
    public Reborn_Management reborn_management;
    public GameObject Canvas;
    private float label;

    public GameObject CheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        label = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(transform.name == "Reborn_Place2" && reborn_management.Reload_Label != 2)
            {
                /*
                if(CheckPoint.activeSelf == false)
                {
                    CheckPoint.SetActive(true);
                }
                */
                Canvas.SetActive(true);
                label = 2;
                reborn_management.Set_reborn_position(label);
            }

            if (transform.name == "Reborn_Place3" && reborn_management.Reload_Label != 3)
            {
                Canvas.SetActive(true);
                label = 3;
                reborn_management.Set_reborn_position(label);
            }
        }
    }

    

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
