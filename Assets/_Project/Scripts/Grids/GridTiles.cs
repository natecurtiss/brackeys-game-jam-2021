﻿using UnityEngine;
using UnityEngine.Tilemaps;

namespace com.N8Dev.Allete.Grids
{
    public class GridTiles
    {
        //Tilemap
        private readonly Tilemap tilemap;

        public GridTiles(Tilemap _tilemap) => tilemap = _tilemap;

        public bool HasTile(Vector3Int _gridPos) => tilemap.HasTile(_gridPos);
    }
}