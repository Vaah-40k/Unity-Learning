using UnityEngine;
using UnityEngine.InputSystem;

public class AnythingAhead : MonoBehaviour
{
    private RaycastHit LastHit;
    private float OldSpeed;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.azure;
        Gizmos.DrawSphere(LastHit.point, 1f);
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.azure);

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit2, 5f))
        {
            LastHit = hit2;
        }
        // мне нравиться больше этот цвет
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 5f))
            {
                // Debug.Log(hit.collider.name);
                // Debug.Log(hit.distance);
                // Debug.Log(hit.point);
                // Debug.Log("Впереди препятствие");
                if (hit.collider.CompareTag("Door"))
                {
                    Debug.Log("Дверь открылась");
                }
                else if (hit.collider.CompareTag("Coin"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
            else
            {
                Debug.Log("Впереди пусто");
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            if (Physics.Raycast(transform.position, transform.up * 5f * -1f))
            {
                Debug.Log("Игрок на земле");
            }
            else
            {
                Debug.Log("Игрок не на земле");
            }
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit4))
            {
                Debug.Log("Попал в цель");
                hit4.collider.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Debug.Log("Нет попадания");
            }
        }
    }
}
