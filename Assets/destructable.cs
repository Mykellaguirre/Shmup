using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructable : MonoBehaviour
{
    public GameObject explosion; // animation variable

    public int scorevalue=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet bullet = collision.GetComponent<bullet>(); // bullet collision 
        
            if (bullet != null)  // bullet hitting ship then destroy it 
            {
                if (!bullet.isEnemy) // making sure bullet doesnt kill enemy by itself 
                  {
                level.instance.AddScore(scorevalue);
                DestroyShip();
                Destroy(bullet.gameObject);
                 }
            }
        
    }

    void DestroyShip()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);

        level.instance.RemoveEnemy();
        Destroy(gameObject);
    }
}
