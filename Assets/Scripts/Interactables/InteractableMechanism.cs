using DefaultNamespace;
using Mechanisms;
using UnityEngine;

namespace Interactables
{
    public class InteractableMechanism : Interactable
    {
        [SerializeField] private Mechanism _mechanism;
        protected override void Interact()
        {
            base.Interact();
            if(!_mechanism.HasInteracted)
                _mechanism.Interact();
        }
    }
}