using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    public float JumpForce = 10.0f;
    public float MaxVelocity = 0;
    public float MinVelocity = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        Animator animator = this.gameObject.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector2.up * JumpForce);
            animator.Play("Flap");
        }

        this.gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * rigidBody.velocity.y);
    }
}
