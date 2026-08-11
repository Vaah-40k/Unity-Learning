using UnityEngine;

public class Prefab : MonoBehaviour
{
    [SerializeField]
    public GameObject CubePrefab;

    void Start()
    {
        Instantiate(CubePrefab, transform.position + Vector3.forward, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.forward * 2, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.left * 2, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.left, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.right, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.right * 2, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.back, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.back * 2, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.back * 3, Quaternion.identity);
        Instantiate(CubePrefab, transform.position + Vector3.back * 4, Quaternion.identity);
    }

    void Update() { }
}
