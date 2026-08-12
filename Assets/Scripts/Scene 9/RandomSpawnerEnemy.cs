using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;

    private float Timer;

    [SerializeField]
    private float FrequencySpawnEnemy;

    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > FrequencySpawnEnemy)
        {
            Timer -= FrequencySpawnEnemy;
            RandomSpawnEnemy();
        }
    }

    private void RandomSpawnEnemy()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        Vector3 coordinates = new Vector3(x, transform.position.y, z);
        GameObject enemy = Instantiate(Enemy, coordinates, Quaternion.identity);
        DestroyEnemy(enemy);
    }

    private void DestroyEnemy(GameObject enemy)
    {
        Destroy(enemy, 5f);
    }
}
