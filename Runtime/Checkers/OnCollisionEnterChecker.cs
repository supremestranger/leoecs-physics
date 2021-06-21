using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnCollisionEnterChecker : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            EcsPhysicsEventsEmitter.RegisterCollisionEnterEvent(gameObject, other.gameObject, other);
        }
    }
}