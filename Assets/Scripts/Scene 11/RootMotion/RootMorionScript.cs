using UnityEngine;

public class RootMorionScript : MonoBehaviour
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
        if (input.Player.Social.IsPressed())
        {
            animator.SetTrigger("Social");
        }
        Vector2 direction = input.Player.Move.ReadValue<Vector2>();
        animator.SetFloat("X", direction.x, 0.2f, Time.deltaTime);
        animator.SetFloat("Y", direction.y, 0.2f, Time.deltaTime);
    }
}
