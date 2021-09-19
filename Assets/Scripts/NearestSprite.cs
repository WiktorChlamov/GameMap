using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NearestSprite : MonoBehaviour
{
    [SerializeField] private GameObject _controlGameObject;
    [SerializeField] private Camera _camera;
    [SerializeField] private TextMeshProUGUI _tileNameTextField;
    private Tilemap[] _tilemaps;

    public void GetTileName()
    {
        _tilemaps ??= MapCreator.GetTileMaps().ToArray();

        if (_tilemaps.Length > 0)
        {
            _controlGameObject.SetActive(false);

            Vector3 upperLeftCorner = _camera.ViewportToWorldPoint(new Vector3(1, 1, _camera.nearClipPlane));

            FindTile findTile = new FindTile(_tilemaps, upperLeftCorner);

            TileBase tile = findTile.GetTile();

            _tileNameTextField.SetText(tile != null ? tile.name : "No tiles in tilemap");
        }
    }
}
