using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Collision : MonoBehaviour
{

    private Rigidbody2D rb;

    




    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Die();
           
        }
    }


    private void Die()
    {
      

        //sets the rigibody type to static
        rb.bodyType = RigidbodyType2D.Static;
        Restartlevel();


    }


    private void Restartlevel()
    {

        //reloads current leavel
        //need using unity.Scene Managment
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




}
