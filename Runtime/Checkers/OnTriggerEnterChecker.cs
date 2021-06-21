using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerEnterChecker : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        { 
            EcsPhysicsEventsEmitter.RegisterTriggerStayEvent(gameObject, other);
        }
    }
}