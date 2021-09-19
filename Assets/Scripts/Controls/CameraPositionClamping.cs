using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPositionClamping : MonoBehaviour
{
    public static CameraPositionClamping instance;
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;
    [SerializeField] private CompositeCollider2D _mapCollider;

    public CompositeCollider2D MapCollider { get => _mapCollider; set => _mapCollider = value; }

    private void Awake()
    {
        instance ??= this;
    }


    public Vector3 ClampCameraPosition(Vector3 position)
    {
        float halfHeight = _virtualCamera.m_Lens.OrthographicSize;
        float halfWidth = _virtualCamera.m_Lens.Aspect * halfHeight;

        float xValue=Mathf.Clamp(position.x, MapCollider.bounds.min.x + halfWidth, MapCollider.bounds.max.x - halfWidth);
        float yValue=Mathf.Clamp(position.y, MapCollider.bounds.min.y + halfHeight, MapCollider.bounds.max.y - halfHeight);

        return new Vector3(xValue, yValue,position.z);
    }
}
