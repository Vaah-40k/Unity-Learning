using System;
using UnityEngine;

public class SpeedTree : MonoBehaviour
{
    private Animator animator;

    private float Speed = 0f;

    [SerializeField]
    private float SpeedChangesFrames = 0.2f;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Speed <= -1)
            Speed = -1f;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Speed += Time.deltaTime;
            animator.SetFloat("Speed", Speed);
        }
        else
        {
            Speed -= Time.deltaTime;
            animator.SetFloat("Speed", Speed);
        }
    }
}
