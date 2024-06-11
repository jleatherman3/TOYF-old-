using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    public Vector2 MouseDelta;
    public Vector3 MoveComposite;

    public Action OnJumpPerformed;

    public Action OnEatPerformed;

    public Action OnAttackPerformed;

    private Controls controls;

    private void OnEnable()
    {
        if (controls != null)
            return;

        controls = new Controls();
        controls.Player.SetCallbacks(this);
        controls.Player.Enable();
    }

    public void OnDisable()
    {
        controls.Player.Disable();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        MouseDelta = context.ReadValue<Vector2>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveComposite = context.ReadValue<Vector3>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;

        OnJumpPerformed?.Invoke();
    }

    public void OnEat(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;
        OnEatPerformed?.Invoke();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;
        OnAttackPerformed?.Invoke();
    }

}