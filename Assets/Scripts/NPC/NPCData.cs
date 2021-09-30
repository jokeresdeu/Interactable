using System;
using UnityEngine;

namespace NPC
{
    [Serializable]
    public class NPCData
    {
        [SerializeField] private Sprite _npcGameSprite;
        [SerializeField] private DialogueData _dialogueData;

        public Sprite Sprite => _npcGameSprite;
        public DialogueData DialogueData => _dialogueData;
    }
}