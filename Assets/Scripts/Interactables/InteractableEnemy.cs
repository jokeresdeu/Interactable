using Enemies;
using UnityEngine;

namespace Interactables
{
    public class InteractableEnemy : Interactable
    {
        [SerializeField] private Enemy _enemy;

        protected override void Interact()
        {
            base.Interact();
            Player.PlayerAttackSystem.SetAttackTarget(_enemy);
        }
    }
}