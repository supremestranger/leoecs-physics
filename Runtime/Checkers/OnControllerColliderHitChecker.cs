using System;
using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

namespace LeoEcsPhysics
{
    public class OnControllerColliderHitChecker : MonoBehaviour
    {
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            EcsPhysicsEventsEmitter.RegisterControllerColliderHitEvent(gameObject, hit.collider, hit.normal, hit.moveDirection);
        }
    }
}