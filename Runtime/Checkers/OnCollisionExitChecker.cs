using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionExitChecker : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            EcsPhysicsEvents.RegisterCollisionExitEvent(gameObject, other.collider, other.GetContact(0), other.relativeVelocity);
        }
    }
}