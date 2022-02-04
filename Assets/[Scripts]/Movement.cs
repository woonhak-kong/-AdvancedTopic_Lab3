using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private float Speed = 10;

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Horizontal"); 
        float y = Input.GetAxis("Vertical");

        Vector2 right = x * Vector2.right;
        Vector2 up = y * Vector2.up;

        Vector2 force = up + right;
        //rigidBody.velocity = new Vector2(x, y);
        //transform.Translate(new Vector3(x * Time.deltaTime, y * Time.deltaTime,0));
        rigidBody.AddForce(force, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bbb");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("aaaa");
    }

    
    
}
