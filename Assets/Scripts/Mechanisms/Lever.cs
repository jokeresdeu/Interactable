using DefaultNamespace;
using UnityEngine;

namespace Mechanisms
{
    public class Lever : Mechanism
    {
        [SerializeField] private Mechanism _mechanism;

        public override void Interact()
        {
            base.Interact();
            if(!_mechanism.HasInteracted)
                _mechanism.Interact();
        }
    }
}