using UnityEngine;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Дверь открылась");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Дверь закрылась");
    }
}
