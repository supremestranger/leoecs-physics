using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionStayEvent
    {
        public GameObject thisGO;
        public GameObject otherGO;
        public Collision collisionData;
    }
}