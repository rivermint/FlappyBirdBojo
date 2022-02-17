using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collision : MonoBehaviour
{
    public playerMovement movement;

    //will be called whenever object collides with soemthing
    void  Update()
    {
        

        if (GetComponent<Collider>().tag == "Ground")
        {

            movement.enabled = false;
            RestartLevel();
        }

    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
