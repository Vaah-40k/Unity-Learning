using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float x;
    private float z;
    private float speed = 5;

    void Start()
    {
        gameObject.tag = "Player";
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        transform.position += Vector3.right * x * Time.deltaTime * speed;
        transform.position += Vector3.forward * z * Time.deltaTime * speed;
    }
}
