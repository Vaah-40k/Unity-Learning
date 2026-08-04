using UnityEngine;

public class Trap : MonoBehaviour
{
    private float timer;

    void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            timer -= 3f;
            Debug.Log("Игрок получает урон");
        }
    }
}
