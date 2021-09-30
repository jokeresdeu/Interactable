using DefaultNamespace;
using Items;
using UnityEngine;

namespace Interactables
{
    public class InteractableItem : Interactable
    {
        [SerializeField] private ItemBody _itemBody;  
        protected override void Interact()
        {
            base.Interact();
            if (Player.PlayerInventory.AddToInventory(_itemBody.InventoryItem))
            {
                _itemBody.ReturnToPool();
            }
        }
    }
}