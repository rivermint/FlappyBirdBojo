using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] private float PlayerJump = 3f;
    [SerializeField] private float ForwardForce = 3f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
       
            transform.Translate(Vector3.right * ForwardForce * Time.deltaTime);
      

        //uses unity input system 
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, PlayerJump, 0);
        }

        

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {








        if (coll.gameObject.CompareTag("Ground"))
        {




            rb.constraints = RigidbodyConstraints2D.FreezePosition;



        }
    }

}
