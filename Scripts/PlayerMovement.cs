 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;

    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;
    private bool onGround = true;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }

    }

}
