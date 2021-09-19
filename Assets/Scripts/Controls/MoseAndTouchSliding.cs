using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoseAndTouchSliding : TouchAndMouseSettings
{

    void Start()
    {
        _control.Sliding.MapSliding.started += _ => CameraMove();
        _control.Sliding.MapSliding.canceled += _ => StopCameraMoving();
        _control.TouchZooming.SecondaryContact.started += _ => StopCameraMoving();
    }

    private void CameraMove()
    {
        _actionCoroutine ??= StartCoroutine(CameraMoving());
    }
    
    private void StopCameraMoving()
    {
        if (_actionCoroutine != null)
        {
            StopCoroutine(_actionCoroutine);
            _actionCoroutine = null;
        }
    }

    IEnumerator CameraMoving()
    {
        while (true)
        {
           Vector3 movePosition = new Vector3(
            _camera.transform.position.x + _control.Sliding.MouseAndTouchDelta.ReadValue<Vector2>().x * Time.deltaTime * -_cameraSpeed ,
            _camera.transform.position.y + _control.Sliding.MouseAndTouchDelta.ReadValue<Vector2>().y * Time.deltaTime * -_cameraSpeed ,
            _camera.transform.position.z);
            Debug.Log(_control.Sliding.MouseAndTouchDelta.ReadValue<Vector2>());
           movePosition = CameraPositionClamping.instance.ClampCameraPosition(movePosition);
            _camera.transform.position = Vector3.Slerp(_camera.transform.position, movePosition, 0.9f);

            yield return null;
        }
    }
    private Vector2 NormalizeSpeed()
    {
        float defaultResWidth = 2560;
        float defaultResHeight = 1440;
        return new Vector2(defaultResWidth / Screen.width, defaultResHeight / Screen.height);
        
    }
}
