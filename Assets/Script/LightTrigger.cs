using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light targetLight;

    void Start()
    {
        targetLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.transform.root.CompareTag("Player"))
        {
            Debug.Log("LIGHT ON");
            targetLight.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.transform.root.CompareTag("Player"))
        {
            Debug.Log("LIGHT OFF");
            targetLight.enabled = false;
        }
    }
}