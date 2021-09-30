using UnityEngine;

namespace DefaultNamespace
{
    public abstract class InventoryItem
    {
        public string ItemName => "Name";

        public abstract void Use();
    }
}