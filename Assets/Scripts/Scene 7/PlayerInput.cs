using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private float speed = 5f;
    private Vector2 move;

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Начало прыжка");
        }
        else if (context.performed)
        {
            Debug.Log("Прыжок");
        }
        else if (context.canceled)
        {
            Debug.Log("Конец прыжка");
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Атака!");
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Взаимодействие");
        }
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
    }

    private void Update()
    {
        Vector3 movePlayer = new Vector3(move.x, 0f, move.y);
        transform.position += movePlayer * speed * Time.deltaTime;
    }
}
