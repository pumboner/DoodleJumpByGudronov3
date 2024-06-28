using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodle : MonoBehaviour
{
    float horizontal;
    public Rigidbody2D DoodleRigid;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
    
        }
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        DoodleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DoodleRigid.velocity.y);
    }
}
