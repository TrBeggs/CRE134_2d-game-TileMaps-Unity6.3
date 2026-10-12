using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastcameraposition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastcameraposition = cameraTransform.position;
    }

    // Update is called once per frame
    private void latepdate()
    {
        Vector3 deltamovement = cameraTransform.position - lastcameraposition;
        transform.position += deltamovement;
        lastcameraposition = cameraTransform.position;
    }
}
