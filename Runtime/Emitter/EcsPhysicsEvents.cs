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

        public static void RegisterCollisionExitEvent(GameObject senderGameObject, Collider collider, Vector3 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionExitEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
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
        
        public static void RegisterCollisionEnter2DEvent(GameObject senderGameObject, Collider2D collider2D, ContactPoint2D firstContactPoint2D, Vector2 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionEnter2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.firstContactPoint2D = firstContactPoint2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterCollisionStay2DEvent(GameObject senderGameObject, Collider2D collider2D, ContactPoint2D firstContactPoint2D, Vector2 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionStay2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.firstContactPoint2D = firstContactPoint2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterCollisionExit2DEvent(GameObject senderGameObject, Collider2D collider2D, Vector2 relativeVelocity)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnCollisionExit2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterTriggerEnter2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerEnter2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
        
        public static void RegisterTriggerStay2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerStay2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
        
        public static void RegisterTriggerExit2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = ecsWorld.NewEntity();
            ref var eventComponent = ref eventEntity.Get<OnTriggerExit2DEvent>();
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
    }
}