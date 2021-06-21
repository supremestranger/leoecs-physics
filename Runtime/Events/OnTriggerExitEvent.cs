using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnTriggerExitEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
    }
}