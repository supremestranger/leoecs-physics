using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

namespace LeoEcsPhysics
{
    public static class EcsPhysicsEventsEmitter
    {
        public static EcsWorld ecsWorld;

        public static void RegisterTriggerEnterEvent(GameObject thisGO, GameObject otherGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerEnterEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterTriggerStayEvent(GameObject thisGO, GameObject otherGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerStayEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterTriggerExitEvent(GameObject thisGO, GameObject otherGO, Collider colliderData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerExitEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.colliderData = colliderData;
        }

        public static void RegisterCollisionEnterEvent(GameObject thisGO, GameObject otherGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionEnterEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterCollisionStayEvent(GameObject thisGO, GameObject otherGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionStayEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterCollisionExitEvent(GameObject thisGO, GameObject otherGO, Collision collisionData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionExitEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.collisionData = collisionData;
        }

        public static void RegisterControllerColliderHitEvent(GameObject thisGO, GameObject otherGO, ControllerColliderHit hitData)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnControllerColliderHitEvent>();
            eventComponent.thisGO = thisGO;
            eventComponent.otherGO = otherGO;
            eventComponent.hit = hitData;
        }
    }
}