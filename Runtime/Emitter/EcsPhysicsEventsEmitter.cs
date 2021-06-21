using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

namespace LeoEcsPhysics
{
    public static class EcsPhysicsEventsEmitter
    {
        public static EcsWorld ecsWorld;

        public static void RegisterTriggerEnterEvent(GameObject thisGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerEnterEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterTriggerStayEvent(GameObject thisGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerStayEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterTriggerExitEvent(GameObject thisGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerExitEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterCollisionEnterEvent(GameObject thisGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionEnterEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterCollisionStayEvent(GameObject thisGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionStayEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterCollisionExitEvent(GameObject thisGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionExitEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterControllerColliderHitEvent(GameObject thisGO, ControllerColliderHit hitData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnControllerColliderHitEvent>();
            eventComponent.senderGameObject = thisGO;
            eventComponent.hit = hitData;
        }
    }
}