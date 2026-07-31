using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed { get; private set; } = 5f;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log("w");
            transform.position += speed * Time.deltaTime * Vector3.forward;
        }
        else if (Input.GetKey("a"))
        {
            Debug.Log("a");

            transform.position += speed * Time.deltaTime * Vector3.left;
        }
        else if (Input.GetKey("s"))
        {
            Debug.Log("s");

            transform.position += speed * Time.deltaTime * Vector3.back;
        }
        else if (Input.GetKey("d"))
        {
            Debug.Log("d");

            transform.position += speed * Time.deltaTime * Vector3.right;
        }
    }
}
