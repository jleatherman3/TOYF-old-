using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //public Rigidbody rb;
    public float moveSpeed = 5f;
    //public InputAction Controls;
    //[SerializeField]
    //public PlayerController playerController;

    //Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        //moveDirection = new Vector3(moveX, moveY).normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
