using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float movespeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        { 
            Vector3 touuchPos =Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touuchPos.x < 0)
            {
                rb.AddForce(Vector2.left * movespeed);
            }
            else
            {
                rb.AddForce(Vector2.right * movespeed);
            }

       
        
        
        }
        else
        {
            rb.velocity=Vector2.zero;
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene(0);
        }
    }
}
