using UnityEngine;

namespace Mechanisms
{
    public abstract class Mechanism : MonoBehaviour
    {
        public bool HasInteracted { get; private set; }
        public virtual void Interact()
        {
            HasInteracted = true;
        }
    }
}