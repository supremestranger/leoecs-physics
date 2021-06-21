using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionExitEvent
    {
        public GameObject senderGameObject;
        public Collision collisionData;
    }
}