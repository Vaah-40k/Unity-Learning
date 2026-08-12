using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed { get; private set; } = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
