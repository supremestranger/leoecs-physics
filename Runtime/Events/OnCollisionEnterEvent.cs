using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnCollisionEnterEvent
    {
        public GameObject thisGO;
        public GameObject otherGO;
        public Collision collisionData;
    }
}