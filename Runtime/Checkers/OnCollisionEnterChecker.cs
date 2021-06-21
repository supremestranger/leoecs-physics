using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionEnterChecker : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            EcsPhysicsEventsEmitter.RegisterCollisionStayEvent(gameObject, other);
        }
    }
}