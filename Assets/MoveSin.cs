using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    float sinCenterY;
    public float amplitude = 2;// size of wave 
    public float frequency = 2;// frequency of wave 
    public bool inverted = false;// bool for inversion 

    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;// centering position of sin wave 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x* frequency) * amplitude ;// creating the sin wave movement 
        if (inverted)// invert one of the enemy groups 
        {
            sin *= -1;
        }
        pos.y = sinCenterY+ sin;



        transform.position = pos;

    }
}
