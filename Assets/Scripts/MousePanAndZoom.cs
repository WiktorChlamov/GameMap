using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MousePanAndZoom : MonoBehaviour
{
    [SerializeField] private float _panSpeed = 2f, _zoomSpeed=3f, _zoomInMax, _zoomOutMax;
    [SerializeField] private CinemachineInputProvider _inputProvider;
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;
    [SerializeField] private bool _isPan =false;
    private Transform _camera;
    private PanDirection panDirection = new PanDirection();

    private void Awake()
    {
        _camera = _virtualCamera.transform;
    }

    void Update()
    {
        float x = _inputProvider.GetAxisValue(0);
        float y = _inputProvider.GetAxisValue(1);
        float z = _inputProvider.GetAxisValue(2);

        if(_isPan && (x != 0 || y!= 0))
        {
            PanScreen(x, y);
        }

        if(_zoomSpeed!=0)
        {
            ZoomScreen(z);
        }
    }

    public void ZoomScreen(float increment)
    {
        float orthographicSize = _virtualCamera.m_Lens.OrthographicSize;
        float target = Mathf.Clamp(orthographicSize + increment, _zoomInMax, _zoomOutMax);
        _virtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(orthographicSize, target, _zoomSpeed);
        _camera.position = CameraPositionClamping.instance.ClampCameraPosition(_camera.position);
    }

    public Vector2 GetPanDirection(float x,float y)=>panDirection.GetDirection(x, y);

    public void PanScreen(float x, float y)
    {
        Vector2 direction = GetPanDirection(x, y);
        Vector3 targetPosition = _camera.position + (Vector3)direction * _panSpeed;

        targetPosition = CameraPositionClamping.instance.ClampCameraPosition(targetPosition);
        _camera.position = Vector3.Lerp(_camera.position,targetPosition,Time.deltaTime);
    }
}
