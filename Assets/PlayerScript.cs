using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5;
    private bool isOnGround = true;
    private float horizonalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizonalInput);

        //jump
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround== true)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (col.gameObject.CompareTag("Respawn"))
        {
            Debug.Log($"good");
        }
    }   
}   /// <summary>
/// OnTriggerEnter is called when the Collider other enters the trigger.
/// </summary>
/// <param name="other">The other Collider involved in this collision.</param>
    