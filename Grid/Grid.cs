using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GridEngine {
    public class GameGrid<GridType>
    {
        private int     _width;
        private int     _height;
        private GridType[,] _gridArray;
        private float   _cellSize;
        private Vector3 _originPosition;

        public GameGrid(int width,int height, float cellSize, Vector3 originPosition)
        {
            _width          = width;
            _height         = height;
            _originPosition = originPosition;
            _gridArray      = new GridType[width, height];
            _cellSize       = cellSize;

            for (int x = 0; x < _gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < _gridArray.GetLength(1); y++)
                {
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white ,1000f);
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 1000f);
                }
            }
            Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white ,1000f);
            Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white ,1000f);
        }

        private Vector3 GetWorldPosition(int x, int y)
        {
            return new Vector3(x, y) * _cellSize + _originPosition;
        }
        
        private void GetXY (Vector3 worldPosition, out int x, out int y)
        {
            x = Mathf.FloorToInt((worldPosition - _originPosition).x / _cellSize);
            y = Mathf.FloorToInt((worldPosition - _originPosition).y / _cellSize);
        }

        #region Setters
        /// <summary>
        /// Sets the value of a cell given a coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public void SetValue(int x, int y, GridType value)
        {
            if( x >= 0 && x < _width && y >= 0 && y < _height)
                _gridArray[x, y] = value;
        }

        /// <summary>
        /// Sets the value of a cell given a world coordinates
        /// </summary>
        /// <param name="worldPosition"></param>
        /// <param name="value"></param>
        public void SetValue(Vector3 worldPosition, GridType value)
        {
            int x, y;
            GetXY(worldPosition, out x, out y);
            Debug.Log(x + " " + y);
            SetValue(x, y, value);

        }
        #endregion

        public GridType GetValue(int x, int y)
        {
            if (x >= 0 && x < _width && y >= 0 && y < _height)
                return _gridArray[x, y];
            else 
                return default(GridType);
        }

        public GridType GetValue(Vector3 worldPos)
        {
            int x, y;
            GetXY(worldPos, out x, out y);
            return GetValue(x, y);
        }

        #region Debug

        public void DebugArray()
        {
            string res = "";
            for (int x = 0; x < _gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < _gridArray.GetLength(1); y++)
                {
                    res += "[" + _gridArray[x, y] + "] ";
                }
                res += '\n';
            }
            Debug.Log(res); 
        }
        #endregion 
    }
}
