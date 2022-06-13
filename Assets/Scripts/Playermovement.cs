using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Vector3 playerPosition;
    public float movementSpeed;
    public float jumpForce;
    public int maxJumps;
    public AudioManager miAm;
    public float waitforcameraadjustment;
    int hasJump;
    Rigidbody rb;
    public GameObject fruit;

    public GameObject enemyWhoDies;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = transform.position + new Vector3(0, 1, 0);
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        waitforcameraadjustment -= Time.deltaTime;
        if (waitforcameraadjustment < 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(-movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(0, 0, movementSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0, 0, -movementSpeed);
            }

            if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                hasJump--;
            }
        }
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = maxJumps;
        }
    }
    


}