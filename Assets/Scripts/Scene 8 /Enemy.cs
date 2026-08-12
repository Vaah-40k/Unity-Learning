using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyData data;

    void Start()
    {
        Debug.Log($"Имя экземпляра - {data.Name}");
        Debug.Log($"Здоровье экземпляра - {data.Health}");
        Debug.Log($"Урон экземпляра - {data.Damage}");
        Debug.Log($"Скорость экземпляра - {data.Speed}");
    }

    void Update() { }
}
