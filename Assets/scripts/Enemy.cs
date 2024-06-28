using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int stepsPerDirection = 400;

    private int direction = 1;
    private int stepsLeft;
    
    private UnityEngine.Object explosion;
    
    public int health = 100;


    private void Start()
    {
        stepsLeft = stepsPerDirection;
        explosion = Resources.Load("Explosion");
    }

    private void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime * direction, 0, 0);
        stepsLeft--;

        if (stepsLeft == 0)
        {
            direction *= -1;
            stepsLeft = stepsPerDirection;
        }
    }
   private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
   }
   public void TakeDamage (int damage)
   {
    health -= damage;
    if(health <= 0)
    {
        GameObject explosionRef = (GameObject)Instantiate(explosion);
        explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(gameObject);


    }
   }


}
