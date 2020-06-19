using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = (transform.GetChild(1).right * x) + (transform.GetChild(1).forward * z);

        controller.Move(move * speed * Time.deltaTime);
        
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime );
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "b_portal")
        {
            SceneManager.LoadScene("bathroom");
        }
        else if (collision.gameObject.tag == "b_back")
        {
            SceneManager.LoadScene("classroom");
        }
        else if (collision.gameObject.tag == "e_portal")
        {
            SceneManager.LoadScene("elavator");
        }
        else if (collision.gameObject.tag == "e_back")
        {
            SceneManager.LoadScene("classroom");
        }
    }
}
