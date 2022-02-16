using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] private float PlayerJump = 3f;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
       




        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, PlayerJump, 0);
        }



    }
}
