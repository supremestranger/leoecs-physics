using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

namespace LeoEcsPhysics
{
    public static class EcsPhysicsEvents
    {
        public static EcsWorld ecsWorld;

        public static void RegisterTriggerEnterEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerEnterEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerStayEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerStayEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerExitEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerExitEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterCollisionEnterEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionEnterEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionStayEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionStayEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionExitEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionExitEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterControllerColliderHitEvent(GameObject senderGameObject, Collider collider, Vector3 hitNormal, Vector3 moveDirection)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnControllerColliderHitEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.hitNormal = hitNormal;
            eventComponent.moveDirection = moveDirection;
        }
    }
}