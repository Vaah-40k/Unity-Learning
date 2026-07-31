using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed { get; private set; } = 5f;

    void Start()
    {
        transform.rotation = Quaternion.Euler(-1, 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
