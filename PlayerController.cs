using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpVelocity = 20.0f;
    [SerializeField] private float gravity;
    [SerializeField] private bool isGrounded = false;

    private Vector2 velocity;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                velocity.y = jumpVelocity;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        if (!isGrounded)
        {
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y -= gravity * Time.fixedDeltaTime;
        }
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}




