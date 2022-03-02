using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public float speed = 2;

    public Vector2 velocity;

    public bool isEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);  // destroy after 3 seconds 
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed; // velocity of bullet
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
