using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    private float Speed = 0f;
    private float Blend = 0f;

    private Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Speed <= 0)
            Speed = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Speed += Time.deltaTime;
            animator.SetFloat("Speed", Speed);
        }
        else
        {
            Speed -= Time.deltaTime;
            animator.SetFloat("Speed", Speed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("Social");
        }
    }

    public void SayHello()
    {
        Debug.Log("Здравствуйте!");
    }
}
