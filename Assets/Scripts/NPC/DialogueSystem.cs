using UnityEngine;
using UnityEngine.UI;

namespace NPC
{
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField] private Image _npcIcon;
        [SerializeField] private Transform _textHolder;
        public void StartDialogue(DialogueData dialogueData)
        {
            _npcIcon.sprite = dialogueData.NpcDialogueIcon;
            GenerateDialogue(dialogueData.Dialogue);
        }

        private void GenerateDialogue(string[] dialogue)
        {
            
        }
    }
}