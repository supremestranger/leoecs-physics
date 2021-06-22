using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnTriggerEnterChecker : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        { 
            EcsPhysicsEvents.RegisterTriggerEnterEvent(gameObject, other);
        }
    }
}
