using UnityEngine;

public class BulletScene9 : MonoBehaviour
{
    // Метод деактивации пуль через OnCollisionEnter
    // void OnCollisionEnter(Collision collision)
    // {
    //     gameObject.SetActive(false);
    // }

    // Метод деактивации пуль через Raycast

    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * 0.4f);
        if (Physics.Raycast(transform.position, transform.up, out RaycastHit hit, 0.4f))
        {
            gameObject.SetActive(false);
        }
    }
}
