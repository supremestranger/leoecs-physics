using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnTriggerStayEvent
    {
        public GameObject thisGO;
        public GameObject otherGO;
        public Collider colliderData;
    }
}