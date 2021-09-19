using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Tilemaps;
public abstract class MapCreator:MonoBehaviour
{
    [SerializeField] protected Tilemap _tilemap;
    [SerializeField] protected SavedTile list = new SavedTile();
    [SerializeField] protected TextAsset _JSONFile;
    [SerializeField] protected float _xCellSize, _yCellSize;
    [SerializeField] protected Grid _grid;

    protected static readonly List<Tilemap> tilemaps = new List<Tilemap>();

    public static List<Tilemap> GetTileMaps() => tilemaps;

    public virtual void CreateMap()
    {
        tilemaps.Add(_tilemap);
        list = JsonUtility.FromJson<SavedTile>(_JSONFile.text);

        foreach (MapTiles mapTiles in list.List)
        {
            TileBase tileBase = Resources.Load($"Tiles/{mapTiles.Id}") as TileBase;
            Vector3Int vector3Int = new Vector3Int((int)(mapTiles.X / mapTiles.Width), (int)(mapTiles.Y / mapTiles.Height), 0);

            if (mapTiles.Width == _xCellSize)
            {
                _tilemap.SetTile(vector3Int, tileBase);
            }
        }
    }
}

