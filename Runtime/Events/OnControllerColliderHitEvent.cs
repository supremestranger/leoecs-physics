using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnControllerColliderHitEvent
    {
        public GameObject senderGameObject;
        public ControllerColliderHit hit;
    }
}