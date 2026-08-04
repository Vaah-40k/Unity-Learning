using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Игрок столкнулся с {collision.gameObject.name} ");
    }
}
