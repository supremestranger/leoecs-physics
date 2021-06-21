using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerStayChecker : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            EcsPhysicsEventsEmitter.RegisterTriggerStayEvent(gameObject, other.gameObject);
        }
    }
}