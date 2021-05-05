using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    public GameObject explosion;

    void Update()
    {
        if (State == BirdState.HitSomething)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
