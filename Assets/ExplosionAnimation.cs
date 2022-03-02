using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAnimation : MonoBehaviour
{
    // Start is called before the first frame update
  void ExplosionDone()
    {
        Destroy(gameObject);
    }
}
