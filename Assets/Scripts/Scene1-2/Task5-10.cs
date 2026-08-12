using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Task519 : MonoBehaviour
{
    public float speedHeight { get; private set; } = 1f;

    // public GetItem PositionItems = new GetItem();

    // public GameObject player = gameObject; // вот так он орёт, я не знаю как сделать переменную глобальной

    void Start()
    {
        GameObject player = gameObject;
        GameObject weapon = new GameObject("weapon");
        weapon.AddComponent<BoxCollider>();
        MeshFilter mf = weapon.AddComponent<MeshFilter>();
        mf.mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        MeshRenderer msrend = weapon.AddComponent<MeshRenderer>();
        msrend.material = new Material(Shader.Find("Standard"));
        weapon.transform.SetParent(player.transform);
        weapon.AddComponent<Weapon>();
    }

    // void Update()
    // {
    //     float[] positionItems = PositionItems.PositionObject();
    //     Debug.Log(positionItems[0]);
    //     // float Size = speedHeight * Time.deltaTime;
    //     // transform.localScale += new Vector3(Size, Size, Size); // я не понял почему нельзя в Update
    // }
}
