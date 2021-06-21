using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionExitEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
        public ContactPoint firstContactPoint;
        public Vector3 relativeVelocity;
    }
}