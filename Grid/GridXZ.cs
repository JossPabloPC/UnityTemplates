using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GridEngine
{
    public class GridXZ<GridType> : GameGrid<GridType>
    {
        public GridXZ(int width, int height, float cellSize, Vector3 originPosition) : base(width, height, cellSize, originPosition)
        {
            _width = width;
            _height = height;
            _originPosition = originPosition;
            _gridArray = new GridType[width, height];
            _cellSize = cellSize;

            for (int x = 0; x < _gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < _gridArray.GetLength(1); y++)
                {
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 1000f);
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 1000f);
                }
            }
            Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 1000f);
            Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 1000f);
        }

        protected override Vector3 GetWorldPosition(int x, int y)
        {
            return new Vector3(x, 0 , y) * _cellSize + _originPosition;
        }
        protected override void GetXY(Vector3 worldPosition, out int x, out int y)
        {
            x = Mathf.FloorToInt((worldPosition - _originPosition).x / _cellSize);
            y = Mathf.FloorToInt((worldPosition - _originPosition).z / _cellSize);
        }

    }
}