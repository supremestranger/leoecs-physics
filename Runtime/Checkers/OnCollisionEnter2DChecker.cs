using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionEnter2DChecker : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            EcsPhysicsEvents.RegisterCollisionEnter2DEvent(gameObject, other.collider, other.GetContact(0), other.relativeVelocity);
        }
    }
}