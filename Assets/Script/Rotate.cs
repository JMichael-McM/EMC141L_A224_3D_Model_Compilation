using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up;
    public float degreesPerSecond = 20f;

    void Update()
    {
        transform.Rotate(rotationAxis * degreesPerSecond * Time.deltaTime, Space.World);
    }
}