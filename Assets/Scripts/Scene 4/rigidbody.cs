using UnityEngine;

public class rigidbody : MonoBehaviour
{
    private Rigidbody rb;
    private float x;
    private float y;
    private float speed = 5;

    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.mass = 2;
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * 5, ForceMode.Impulse); // почему куб стоит на месте? Сменив мод на Impulse куб взлетает. Time.DeltaTime опущен, ибо это просто обучающий урок
        }
    }

    void FixedUpdate()
    {
        if (x != 0)
        {
            rb.MovePosition(rb.position + x * Vector3.right * Time.fixedDeltaTime * speed);
        }

        if (y != 0)
        {
            rb.MovePosition(rb.position + y * Vector3.forward * Time.fixedDeltaTime * speed);
        }
    }
}
