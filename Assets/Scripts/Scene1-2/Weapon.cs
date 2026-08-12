using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform parent = transform.parent;
        Debug.Log(parent.name);
    }

    // Update is called once per frame
    void Update() { }
}
