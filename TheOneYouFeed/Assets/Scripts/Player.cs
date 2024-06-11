using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, Controls.IPlayerActions
{
    [SerializeField] static float speed = 1.0f;
    [SerializeField] private Vector3 _direction;
    float dSpeed;


    // Start is called before the first frame update
    void Start()
    {
        dSpeed = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * (horizontalInput * dSpeed));
        transform.Translate(Vector3.forward * (verticalInput * dSpeed));
    }


    void Controls.IPlayerActions.OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    void Controls.IPlayerActions.OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
    }

    void Controls.IPlayerActions.OnEat(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    void Controls.IPlayerActions.OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    void Controls.IPlayerActions.OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}

