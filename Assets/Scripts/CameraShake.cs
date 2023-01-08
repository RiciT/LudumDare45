using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Transform camTransform;

    private static float shakeDuration = 0;

    private static float shakeAmount = 0.2f;

    private float vel;
    private Vector3 vel2 = Vector3.zero;

    public Vector3 originalPos;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = gameObject.transform;
        }
    }

    public void ShakeOnce(float lenght, float strength)
    {
        shakeDuration = lenght;
        shakeAmount = strength;
        originalPos = transform.position;
    }

    void Update()
    {

        if (shakeDuration > 0)
        {
            Vector3 newPos = originalPos + Random.insideUnitSphere * shakeAmount;

            camTransform.localPosition = Vector3.SmoothDamp(camTransform.localPosition, newPos, ref vel2, 0.05f);

            shakeDuration -= Time.deltaTime;
            shakeAmount = Mathf.SmoothDamp(shakeAmount, 0, ref vel, 0.3f);
        }
        else
        {
            camTransform.localPosition = originalPos;
        }
    }
}
