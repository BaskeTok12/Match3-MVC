using CodeBase.Tiles;
using UnityEngine;

namespace CodeBase.Views
{
    public abstract class BaseTileView : MonoBehaviour
    {
        private readonly BaseTile _tile;
        private SpriteRenderer _spriteRenderer;
        
        public BaseTileView(BaseTile tile)
        {
            _tile = tile;
            
            Init();
        }

        protected virtual void Init()
        {
            //_spriteRenderer.sprite = 
        }

        private Sprite GetSpriteByTileType(BaseTile tile)
        {
            return _spriteRenderer.sprite;
        }
    }
}