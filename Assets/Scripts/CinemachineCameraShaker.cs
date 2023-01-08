using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CinemachineCameraShaker : MonoBehaviour
{
    /// the amplitude of the camera's noise when it's idle
    public float IdleAmplitude = 0.1f;
    /// the frequency of the camera's noise when it's idle
    public float IdleFrequency = 1f;

    /// The default amplitude that will be applied to your shakes if you don't specify one
    public float DefaultShakeAmplitude = .5f;
    /// The default frequency that will be applied to your shakes if you don't specify one
    public float DefaultShakeFrequency = 10f;

    protected Vector3 _initialPosition;
    protected Quaternion _initialRotation;

    protected Cinemachine.CinemachineBasicMultiChannelPerlin _perlin;
    protected Cinemachine.CinemachineVirtualCamera _virtualCamera;

    protected virtual void Awake()
    {
        _virtualCamera = GameObject.FindObjectOfType<Cinemachine.CinemachineVirtualCamera>();
        _perlin = _virtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
    }

    protected virtual void Start()
    {
        CameraReset();
    }

    public virtual void ShakeCamera(float duration)
    {
        StartCoroutine(ShakeCameraCo(duration, DefaultShakeAmplitude, DefaultShakeFrequency));
    }

    public virtual void ShakeCamera(float duration, float amplitude, float frequency)
    {
        StartCoroutine(ShakeCameraCo(duration, amplitude, frequency));
    }

    protected virtual IEnumerator ShakeCameraCo(float duration, float amplitude, float frequency)
    {
        _perlin.m_AmplitudeGain = amplitude;
        _perlin.m_FrequencyGain = frequency;
        yield return new WaitForSeconds(duration);
        CameraReset();
    }

    public virtual void CameraReset()
    {
        _perlin.m_AmplitudeGain = IdleAmplitude;
        _perlin.m_FrequencyGain = IdleFrequency;
    }

}
