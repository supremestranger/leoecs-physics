using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionStayEvent
    {
        public GameObject senderGameObject;
        public Collision collisionData;
    }
}