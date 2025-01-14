using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
        rb.velocity = transform.up * speed;
         
    }
   void OnTriggerEnter2D (Collider2D hitInfo)
   {
    Enemy enemy = hitInfo.GetComponent<Enemy>();
    if (enemy != null)
    {
        enemy.TakeDamage(damage);
        Destroy(gameObject);
    }

   }
}
