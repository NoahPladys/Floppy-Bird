using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    public float JumpForce = 10.0f;
    private bool isAlive = true;

    void Update()
    {
        Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();
        Animator animator = gameObject.GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            StatsManager.GetInstance().Tubes = true;
            rigidBody.AddRelativeForce(Vector2.up * JumpForce);
            animator.Play("Flap");
        }
        
        gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * rigidBody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();

        isAlive = false;
        StatsManager.GetInstance().IsPlaying = false;
        StatsManager.GetInstance().Tubes = false;
        StatsManager.GetInstance().Tubes = false;
        rigidBody.constraints = RigidbodyConstraints2D.None;
    }
}
