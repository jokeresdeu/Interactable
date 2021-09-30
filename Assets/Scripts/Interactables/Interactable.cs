using System;
using Player;
using UnityEngine;

namespace Interactables
{
   public abstract class Interactable : MonoBehaviour
   {
      [SerializeField] private float _interactionDistance;
      protected PlayerCreature Player;
      private bool _hasInteracted;

      private void Start()
      {
         throw new NotImplementedException();
      }

      public void FocusPlayer(PlayerCreature player)
      {
         Player = player;
      }

      public void UnfocusPlayer()
      {
         Player = null;
         _hasInteracted = false;
      }

      private void Update()
      {
         if (Player != null)
         {
            if (Vector2.Distance(Player.transform.position, transform.position) <= _interactionDistance && !_hasInteracted)
            {
               Interact();
            }
         }
      }

      protected virtual void Interact()
      {
         _hasInteracted = true;
      }
   }
}
