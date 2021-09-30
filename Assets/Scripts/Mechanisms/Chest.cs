using DefaultNamespace;

namespace Mechanisms
{
    public class Chest : Mechanism
    {
        public override void Interact()
        {
            base.Interact();
            DropItems();
        }

        private void DropItems()
        {
            
        }
    }
}