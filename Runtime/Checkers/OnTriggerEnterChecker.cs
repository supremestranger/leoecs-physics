using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerEnterChecker : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        { 
            EcsPhysicsEventsEmitter.RegisterTriggerEnterEvent(gameObject, other.gameObject, other);
        }
    }
}