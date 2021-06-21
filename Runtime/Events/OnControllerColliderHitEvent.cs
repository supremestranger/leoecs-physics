using UnityEngine;

namespace LeoEcsPhysics
{
    public struct OnControllerColliderHitEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
        public Vector3 hitNormal;
    }
}