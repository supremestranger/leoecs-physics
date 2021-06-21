using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionStayChecker : MonoBehaviour
    {
        private void OnCollisionStay(Collision other)
        {
            EcsPhysicsEventsEmitter.RegisterCollisionStayEvent(gameObject, other.gameObject, other);
        }
    }
}