using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 6;
    public GameObject explosionPrefab;


    public GameObject player;//玩家对象
    public Transform playerposition;
    private float damping = 100f;
    float distance;//玩家和敌人之间的距离
    bool bulletCheck;
    public static bool explosionCheck;


    // Use this for initialization
    void Start()
    {
        bulletCheck = true;
        explosionCheck = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //玩家和敌人之间的距离，实时更新
        distance = Vector3.Distance(transform.position, player.transform.position);
        //调用距离改变函数

        statechange();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        if (explosionCheck ==true)
        {
            explosionCheck = false;
            Invoke("explosion",0f);
        }

    }




    void statechange()
    {
        if (distance < 0.9)//如果状态为0
        {
            
            //var lookPos = playerposition.position;
            //lookPos.y = 0;
            transform.LookAt(playerposition.position);
            //var lookPos = playerposition.position - transform.position;
            //lookPos.y = 0;
            //var rotation = Quaternion.LookRotation(lookPos);
            //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);


            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);


            if (distance < 0.9 && bulletCheck == true)//攻击
            {
                if(player.transform.parent == transform.parent || player.transform.parent.parent == transform.parent)
                {
                    bulletCheck = false;
                    Invoke("Fire", 1.5f);
                } 
            }

        }
        //Debug.DrawLine(transform.position,player.transform.position,Color.red);//敌人和玩家之间画一条红线
    }
    // Start is called before the first frame update


    void Fire()
    {
        bulletCheck = true;    // Create the Bullet from the Bullet Prefab
        GameObject bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // Destroy the bullet after 2 seconds
        bullet.transform.parent = transform.parent;
        Destroy(bullet, 2.0f);
        CancelInvoke("enemysoundcontronller");
    }

    void explosion()
    {
        GameObject explosion = (GameObject)Instantiate(
        explosionPrefab,
        bulletprefab.bulletposition,
        bulletSpawn.rotation);

        explosion.transform.parent = transform.parent;
        Destroy(explosion, 1.5f);
        CancelInvoke("explosion");
    }

}
