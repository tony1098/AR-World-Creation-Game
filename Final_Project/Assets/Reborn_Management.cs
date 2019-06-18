using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reborn_Management : MonoBehaviour
{
    public DefaultTrackableEventHandler first_field;
    public DefaultTrackableEventHandler reborn_field2;
    public DefaultTrackableEventHandler reborn_field3;

    public GameObject Player;
    public Health_Management health_management;

    public GameObject Canvas;
    public GameObject CheckPoint;

    public Vector3 reborn_position;
    private float Label;
    public float Reload_Label;
    

    

    // Start is called before the first frame update
    void Start()
    {
        Reload_Label = 1;
    }

    public void Set_reborn_position(float label)
    {
        Label = label;
    }

    public void OnBtnChange()
    {
        Reload_Label = Label;
        Canvas.SetActive(false);
    }

    public void OnBtnUnChange()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = first_field.transform.position;

        if (Player.activeSelf == true && Player.transform.position.y <= first_field.transform.position.y - 2)
        {
            if (Reload_Label == 1)
            {
                reborn_position = first_field.transform.GetChild(1).position;
                Player.transform.parent = first_field.transform;

                if (first_field.show == 1)
                {
                    Player.transform.position = reborn_position;
                    print("back1");
                    if (CheckPoint.activeSelf == false)
                    {
                        CheckPoint.SetActive(true);
                    }
                }
                else if (first_field.show == 0)
                {
                    Player.transform.position += new Vector3(0, 2, 0);
                    first_field.have = 0;
                    Player.SetActive(false);
                }

            }
            else if(Reload_Label == 2)
            {
                reborn_position = reborn_field2.transform.GetChild(1).position;
                Player.transform.parent = reborn_field2.transform;

                if (reborn_field2.show == 1)
                {
                    Player.transform.position = reborn_position;
                    print("back2");
                    if (CheckPoint.activeSelf == false)
                    {
                        CheckPoint.SetActive(true);
                    }
                    
                }
                else if (reborn_field2.show == 0)
                {
                    Player.transform.position += new Vector3(0, 2, 0);
                    reborn_field2.have = 0;
                    Player.SetActive(false);
                }
            }
            else if (Reload_Label == 3)
            {
                reborn_position = reborn_field3.transform.GetChild(1).position;
                Player.transform.parent = reborn_field3.transform;

                if (reborn_field3.show == 1)
                {
                    Player.transform.position = reborn_position;
                    print("back3");
                    if (CheckPoint.activeSelf == false)
                    {
                        CheckPoint.SetActive(true);
                    }

                }
                else if (reborn_field3.show == 0)
                {
                    Player.transform.position += new Vector3(0, 1, 0);
                    reborn_field3.have = 0;
                    Player.SetActive(false);
                }
            }

            health_management.health -= 1;
        }

    }
}
