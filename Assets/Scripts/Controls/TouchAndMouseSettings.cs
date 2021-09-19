using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndMouseSettings: MonoBehaviour
{
    [SerializeField] protected CinemachineVirtualCamera _virtualCamera;
    [SerializeField] protected float _cameraSpeed;
    protected Transform _camera;
    protected Control _control;
    protected Coroutine _actionCoroutine;

    private void Awake()
    {
        _camera = _virtualCamera.transform;
        _control = new Control();
    }

    private void OnEnable()
    {
        _control.Enable();
    }

    private void OnDisable()
    {
        _control.Disable();
    }
}
