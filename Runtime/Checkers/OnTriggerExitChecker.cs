using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerExitChecker : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            EcsPhysicsEventsEmitter.RegisterTriggerStayEvent(gameObject, other);
        }
    }
}