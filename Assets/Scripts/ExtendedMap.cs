using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExtendedMap :MapCreator
{
    [SerializeField] private BaseMap baseMap;

    public override void CreateMap()
    {
        baseMap.CreateMap();
        _grid.transform.localPosition = new Vector3(_xCellSize/ 2, 0, 0);
        base.CreateMap();
    }
}
