using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);  
        rb.velocity = new Vector2(xInput*speed,rb.velocity.y);
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 1, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, -1, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0);
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
    }
}
