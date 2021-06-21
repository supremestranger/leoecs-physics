using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionEnterEvent
    {
        public GameObject senderGameObject;
        public Collision collisionData;
    }
}