using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    void Start()
    {
        animator.SetTrigger("Scale");
    }
}
