using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bullet bullet;

    public bool autoshoot = false;
    public float shootIntervalSeconds = 0.5f;
    public float shootDelaySeconds = 0.0f;
    public float shootTimer = 0f;
    public float delayTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(autoshoot) // compare bool
        {
            if (delayTimer >= shootDelaySeconds) // delay timer greater than shoot delay then start shooting otherwise just keep incrementing timer 
            {
                if (shootTimer >= shootIntervalSeconds) // if shoot timer is greater than interval then shoot 
                {
                    Shoot();
                    shootTimer = 0;// reset the shoot timer
                }
                else
                {
                    shootTimer += Time.deltaTime;
                }
                
                 
            }
            else
            {
                delayTimer += Time.deltaTime;
            }
        }
    }

    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);

    }
}
