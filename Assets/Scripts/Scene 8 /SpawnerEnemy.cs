using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    void Start()
    {
        Instantiate(enemy);
    }
}
