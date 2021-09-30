using DefaultNamespace;
using TMPro;
using UnityEngine;

namespace Items
{
    public class ItemBody : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private TMP_Text _itemName;
        public InventoryItem InventoryItem { get; private set; }
        

        public void SetItem(Sprite inGameSprite, InventoryItem item)
        {
            InventoryItem = item;
            _spriteRenderer.sprite = inGameSprite;
            _itemName.text = item.ItemName;
        }

        public void ReturnToPool()
        {
            
        }
    }
}