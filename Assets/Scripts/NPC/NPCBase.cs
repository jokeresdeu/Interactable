using DefaultNamespace;
using UnityEngine;

namespace NPC
{
    public class NPCBase : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        public NPCData NpcData { get; private set; }

        public void ConfigurateNPC(NPCData data)
        {
            _spriteRenderer.sprite = data.Sprite;
            NpcData = data;
        }
    }
}