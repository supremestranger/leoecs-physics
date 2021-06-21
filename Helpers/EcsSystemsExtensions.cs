using Leopotam.Ecs;

namespace LeoEcsPhysics
{
    public static class EcsSystemsExtensions
    {
        public static EcsSystems OneFramePhysics(this EcsSystems ecsSystems)
        {
            ecsSystems.OneFrame<OnTriggerEnterEvent>();
            ecsSystems.OneFrame<OnTriggerStayEvent>();
            ecsSystems.OneFrame<OnTriggerExitEvent>();
            ecsSystems.OneFrame<OnCollisionEnterEvent>();
            ecsSystems.OneFrame<OnCollisionStayEvent>();
            ecsSystems.OneFrame<OnCollisionExitEvent>();
            ecsSystems.OneFrame<OnControllerColliderHitEvent>();

            return ecsSystems;
        }
    }
}