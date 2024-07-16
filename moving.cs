using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{



    Rigidbody2D rb;
    Vector2 move;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));


        //this is first move action scripts
      //  transform.Translate(move *Time.deltaTime * speed);

    }

    private void FixedUpdate()
    {
        //this is fourth scripts of addforce
       // rb.AddForce(move * speed,ForceMode2D.Impulse);



        //this is third scripts of velocity;
        // rb.velocity = move * speed;
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);// its only move left and right not up and down



        //this is second move scripts  its work alright Moveposition
     //   rb.MovePosition(rb.position + move * speed * Time.deltaTime );//there some part is optional(* speed *time.deltatime)
    }
}
