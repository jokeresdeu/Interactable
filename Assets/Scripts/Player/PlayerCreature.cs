using System;
using DefaultNamespace;
using UnityEngine;

namespace Player
{
    public class PlayerCreature : MonoBehaviour
    {
        [SerializeField] private InputController _inputController;
        [SerializeField] private MovementParams _params;
        [SerializeField] private PlayerInventoryView _inventoryView;

        public event Action OnPlayerDestroyed;
        
        public PlayerMover PlayerMover { get; private set; }
        public PlayerInventory PlayerInventory { get; private set; }
    
        public PlayerAttackSystem PlayerAttackSystem { get; private set; }

        public void Start()
        {
            PlayerMover = new PlayerMover(_params, _inputController, this);
            PlayerInventory = new PlayerInventory(this, _inventoryView);
            PlayerAttackSystem = new PlayerAttackSystem(this);
        }

        private void OnDestroy()
        {
            OnPlayerDestroyed?.Invoke();
        }
    }
}


