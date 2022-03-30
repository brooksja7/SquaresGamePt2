using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

    [SerializeField] private eff back;

    [SerializeField] private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles;
    
    public int count;

    eff backg;
    void Start()
    {
        backg = Instantiate(back, new Vector3(0, 0), Quaternion.identity);
        backg.transform.localScale += new Vector3(_width, _height, 0);
        backg.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
        GenerateGrid();
        
    }
    void GenerateGrid()
    {
        
        _tiles = new Dictionary<Vector2, Tile>();
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                //spawnedTile.transform.localScale -= new Vector3(0.1f, 0, 0);



                _tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if (_tiles.TryGetValue(pos, out var tile)) return tile;
        return null;
    }
}