using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship1 : MonoBehaviour
{
    public float speed = 10.4f; // spped of the ship 

    Gun[] guns; // making an array of guns 

    bool shoot; // for shooting 
    // Start is called before the first frame update
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>(); //lets us call Gun scripts from anywhere 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))   // getting the input for ship movement 
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;

        shoot = Input.GetKeyDown(KeyCode.Space);// hold down lftctrl for shoot 

        if (shoot) // were gonna make it so you click everytime you shoot 
        {
            shoot = false;
            foreach (Gun gun in guns) // checks all guns and shoots them all 
            {
                gun.Shoot();
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet bullet = collision.GetComponent<bullet>();
        if (bullet !=null) 
        {
            if (bullet.isEnemy) // checking if bullet is enemy bullet 
            {
                Destroy(gameObject); // destroying player 
                Destroy(bullet.gameObject);
            }
        }
        destructable destructable = collision.GetComponent<destructable>();
        if ( destructable != null)
        {
            Destroy(gameObject); // destroying player 
            Destroy(bullet.gameObject);
        }
    }
  
}
