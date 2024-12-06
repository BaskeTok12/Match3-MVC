using CodeBase.Global.Enums;
using UnityEngine;

namespace CodeBase.Tiles
{
    public abstract class BaseTile : MonoBehaviour
    {
        private TileType _tileType;

        public BaseTile(TileType tileType)
        {
            _tileType = tileType;
        }
    }
}
