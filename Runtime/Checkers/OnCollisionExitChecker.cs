using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionExitChecker : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            EcsPhysicsEventsEmitter.RegisterCollisionStayEvent(gameObject, other);
        }
    }
}