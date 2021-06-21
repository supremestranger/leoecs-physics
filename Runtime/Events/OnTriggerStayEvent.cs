using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnTriggerStayEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
    }
}