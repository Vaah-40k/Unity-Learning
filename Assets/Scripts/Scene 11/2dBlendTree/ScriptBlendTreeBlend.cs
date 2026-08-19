using System;
using UnityEngine;

public class ScriptBlendTreeBlend : MonoBehaviour
{
    private Animator animator;
    private NewActions input;

    [SerializeField]
    private float speedPlayerMove = 1.5f;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        input = new NewActions();
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }

    void Update()
    {
        Vector2 direction = input.Player.Move.ReadValue<Vector2>();
        Vector3 movePlayer = transform.forward * direction.y + transform.right * direction.x;
        transform.position += movePlayer * speedPlayerMove * Time.deltaTime;
        animator.SetFloat("X", direction.x, 0.2f, Time.deltaTime);
        animator.SetFloat("Y", direction.y, 0.2f, Time.deltaTime);
    }
}
