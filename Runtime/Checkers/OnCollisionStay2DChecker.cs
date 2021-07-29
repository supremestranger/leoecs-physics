using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionStay2DChecker : MonoBehaviour
    {
        private void OnCollisionStay2D(Collision2D other)
        {
            EcsPhysicsEvents.RegisterCollisionStay2DEvent(gameObject, other.collider, other.GetContact(0), other.relativeVelocity);
        }
    }
}