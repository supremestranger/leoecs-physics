using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerExitChecker : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            EcsPhysicsEventsEmitter.RegisterTriggerExitEvent(gameObject, other.gameObject);
        }
    }
}