using System.Collections.Generic;
using DefaultNamespace;

namespace Player
{
    public class PlayerInventory
    {
        private PlayerCreature _playerCreature;
        private List<InventoryItem> _inventoryItems;
        private PlayerInventoryView _inventoryView;
        private int _inventoryCapacity = 100;
        public PlayerInventory(PlayerCreature playerCreature, PlayerInventoryView inventoryView)
        {
            _playerCreature = playerCreature;
            _inventoryView = inventoryView;
        }

        public bool AddToInventory(InventoryItem inventoryItem)
        {
            if (_inventoryItems.Count > _inventoryCapacity)
            {
                return false;
            }
            _inventoryItems.Add(inventoryItem);
            return true; //Add to inventory 
        }
        
    }
}