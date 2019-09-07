using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D other) 
    {
       
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 6f);
            Destroy(gameObject); 
        
         
    }
}
