using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool FaceRight = true;
    public GameObject Buellet;
    GameObject BulletClone;

    public Transform LeftSpawn;

  

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FLipPlayer();
        Fire();
    }
    void FLipPlayer()
    {
        if (Input.GetKeyDown(KeyCode.D) && FaceRight == false)
        {
            sprite.flipX = false;
            FaceRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && FaceRight == true)
        {
            sprite.flipX = true;
            FaceRight = false;
        }
    }    
        void Fire()
        {
            if (Input.GetMouseButtonDown(0) && FaceRight)
            {
                BulletClone = Instantiate(Buellet, transform.position, transform.rotation);
                BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            }
            else if (Input.GetMouseButtonDown(0) && FaceRight)
            {
                BulletClone = Instantiate(Buellet, LeftSpawn.position, LeftSpawn.rotation);
                BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            }
        }
    
}
