using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnTriggerEnterEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
    }
}