using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class move_player : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 4.9f)
            {
                transform.position = transform.position + new Vector3(5f, 0, 0);
            }
          
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -4.9f)
            {
                transform.position = transform.position + new Vector3(-5f, 0, 0);
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemies"))
            SceneManager.LoadScene("IceRoad");
       
            if (transform.position.x == 4.9f )
            {
                transform.position = transform.position + new Vector3(-5f, 0, 0);
            }

            if (transform.position.x ==  -4.9f)
            {
                transform.position = transform.position + new Vector3(5f, 0, 0);
            } 
       

    }
}
