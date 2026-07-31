using UnityEngine;

public class GetItem : MonoBehaviour
{
    public float[] PositionObject()
    {
        float[] Vectors = { transform.position.x, transform.position.y, transform.position.z };
        return Vectors;
    }
}
