using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchZooming : TouchAndMouseSettings
{
    [SerializeField] private float _zoomInMax, _zoomOutMax;
    private void Start()
    {
        _control.TouchZooming.SecondaryContact.started += _ => ZoomStart();
        _control.TouchZooming.SecondaryContact.canceled += _ => ZoomEnd();
    }

    private void ZoomStart()
    {
        _actionCoroutine = StartCoroutine(Zooming());
    }

    private void ZoomEnd()
    {
        StopCoroutine(_actionCoroutine);
    }

    IEnumerator Zooming()
    {
        float previousDistance = 0f;
        while (true)
        {
            float distance = Vector2.Distance(_control.TouchZooming.PrimaryFinger.ReadValue<Vector2>(),
                _control.TouchZooming.SecondaryFinger.ReadValue<Vector2>());

            float orthographicSize = _virtualCamera.m_Lens.OrthographicSize;
            float increment = distance - previousDistance ;
            float target = Mathf.Clamp(orthographicSize - increment, _zoomInMax, _zoomOutMax);

            _virtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(orthographicSize, target, _cameraSpeed);
            _camera.position = CameraPositionClamping.instance.ClampCameraPosition(_camera.position);

            previousDistance = distance;

            yield return null;
        }
    }
}
