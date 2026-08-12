using UnityEngine;

public class CoinGet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Монета подобрана");
            Destroy(gameObject);
        }
    }
}
