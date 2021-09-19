using UnityEngine;
using UnityEngine.Tilemaps;

public class FindTile
{
    private Tilemap[] _tilemaps;
    private Vector3 _pointOfSearch;

    public FindTile(Tilemap[] tilemaps, Vector3 pointOfSearch)
    {
        _tilemaps = tilemaps;
        _pointOfSearch = pointOfSearch;
    }

    public TileBase GetTile()
    {
        TileBase tile = FindTileInTilemaps(_tilemaps, _pointOfSearch);
        return tile ?? FindNearestTilePosition(_tilemaps, _pointOfSearch);
    }

    private TileBase FindNearestTilePosition(Tilemap[] tilemaps, Vector3 vector3)
    {
        TileBase tile = null;
        float distance = 100f;

        foreach (Tilemap tilemap in tilemaps)
        {
            foreach (var pos in tilemap.cellBounds.allPositionsWithin)
            {
                Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);

                if (tilemap.HasTile(localPlace))
                {
                    float newDistance = Vector2.Distance(vector3, new Vector2(localPlace.x, localPlace.y));

                    if (newDistance < distance)
                    {
                        distance = newDistance;
                        tile = tilemap.GetTile(localPlace);
                    }
                }
            }
        }
        return tile;
    }

    private TileBase FindTileInTilemaps(Tilemap[] tilemaps, Vector3 vector3)
    {
        foreach (Tilemap tilemap in tilemaps)
        {
            Vector3Int location = tilemap.WorldToCell(vector3);
            TileBase tile = tilemap.GetTile(location);

            if (tile != null) return tile;
            else continue;
        }
        return null;
    }
}
