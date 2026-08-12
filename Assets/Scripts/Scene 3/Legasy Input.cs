using UnityEngine;

public class LegasyInput : MonoBehaviour
{
    public float speed { get; private set; } = 2;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.up * vertical * Time.deltaTime * speed;
        transform.position += Vector3.right * horizontal * Time.deltaTime * speed;
        speed = 2;

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log("Прыжок");
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.gray; // этот кусок кода по приколу
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= 2;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Рататататататата");
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("Причеливание");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Пауза");
        }
    }
}
