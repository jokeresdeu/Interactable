
using NPC;
using UnityEngine;

namespace Interactables
{
    public class InteractableNPC : Interactable
    {
        [SerializeField] private NPC.NPCBase _npcBase;
        private DialogueSystem _dialogueSystem;
    
        protected override void Interact()
        {
            base.Interact();
            _dialogueSystem.StartDialogue(_npcBase.NpcData.DialogueData);
        }
    }
}
