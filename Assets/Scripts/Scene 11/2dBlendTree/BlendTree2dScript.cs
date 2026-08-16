using UnityEngine;
using UnityEngine.InputSystem;

public class Blend2dTreeScript : MonoBehaviour
{
    private NewActions input;

    private Vector2 move;

    private Animator animator;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        input = new NewActions();
        input.Player.Enable();
    }

    private void Update()
    {
        move = input.Player.Move.ReadValue<Vector2>();
        Debug.Log(move);
        animator.SetFloat("X", move.x, 0.8f, Time.deltaTime);
        animator.SetFloat("Y", move.y, 0.8f, Time.deltaTime);
    }
}
