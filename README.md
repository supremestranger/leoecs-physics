# LeoECS Physics
This is a simple Unity physics events emitter for Leopotam ECS framework.
No more need to create MonoBehaviour scripts for physics events handling - just follow a few simple steps to do it with this tool.

## Installation
You can install this repository via Package Manager:

`Package Manager -> Add package from git URL...`

Fill the opened field with this line:
```
https://github.com/supremestranger/leoecs-physics.git
```

If you can't / don't want to use Package Manager or Git, you can just download the repository and add it to your project.

## Checkers
`Checker` is a `MonoBehaviour` script that contains a specific Unity physics event method.

You need to attach a concrete `Checker` to any `GameObject` that emits any Unity physics events.

### All Checkers:
* `OnTriggerEnterChecker` - responsible for `OnTriggerEnter` event
* `OnTriggerStayChecker` - responsible for `OnTriggerStay` event
* `OnTriggerExitChecker` - responsible for `OnTriggerExit` event
* `OnCollisionEnterChecker` - responsible for `OnCollisionEnter` event
* `OnCollisionStayChecker` - responsible for `OnCollisionStay` event
* `OnCollisionExitChecker` - responsible for `OnCollisionExit` event
* `OnControllerColliderHitChecker` - responsible for `OnControllerColliderHit` (only for `Character Controller` objects) event
> All 2D checkers work in the same way.

## Events
When Unity Physics event is raised, the `EcsPhysicsEvents` static class creates a new entity-event with a specific component like `OnCollisionEnterEvent` or `OnTriggerStayEvent`.

The event component has various amount on fields based on the event.

### OnCollision
```csharp
public GameObject senderGameObject;
public Collider collider;
public ContactPoint firstContactPoint;
public Vector3 relativeVelocity;
```
> **Note**: The contact point is in world-space and not available in `OnCollisionExit` and `OnCollisionExit2D` events!
### OnTrigger
```csharp
public GameObject senderGameObject;
public Collider collider;
```
### OnControllerColliderHit
```csharp
public GameObject senderGameObject;
public Collider collider;
public Vector3 hitNormal;
public Vector3 moveDirection;
```


But before diving into handling all of this stuff, you need to initialize the `EcsPhysicsEvents` in your `Startup` script like this:

```csharp
sealed class EcsStartup : MonoBehaviour
{
    private EcsWorld ecsWorld;
    private EcsSystems ecsSystems;
        
    private void Start()
    {
        ecsWorld = new EcsWorld ();
        ecsSystems = new EcsSystems (ecsWorld);
        // initialization of emitter.
        EcsPhysicsEvents.ecsWorld = ecsWorld;
            
        ecsSystems
            // your systems
            .Add(new TestSystem())
            .Init();
    }

    private void FixedUpdate()
    {
        ecsSystems?.Run ();
    }

    private void OnDestroy()
    {
        if (ecsSystems != null)
        {
            // don't forget to get rid of this reference.
            EcsPhysicsEvents.ecsWorld = null;
            ecsSystems.Destroy();
            ecsSystems = null;
            ecsWorld.Destroy();
            ecsWorld = null;
        }
    }
}
```

You can get data of event in your systems:

```csharp
public class TestSystem : IEcsRunSystem
{
    private EcsFilter<OnCollisionEnterEvent> filter;

    public void Run()
    {
        foreach (var i in filter)
        {
            ref var eventData = ref filter.Get1(i);

            eventData.collider.gameObject.SetActive(false);
         }
    }
}
 
```

You can `OneFrame` some events if you want or you can use `OneFramePhysics()` for `OneFrame`'ing all events:
```csharp
private void Start()
{
    ecsWorld = new EcsWorld ();
    ecsSystems = new EcsSystems (ecsWorld);
    // initialization of emitter.
    EcsPhysicsEventsEmitter.ecsWorld = ecsWorld;
            
    ecsSystems
        // your systems
        .Add(new TestSystem())
        // oneframe all unity physics events.
        .OneFramePhysics()
        .Init();
    }
```

## FAQ
### I attached the Checker to GameObject, but it doesn't register any physics event
Keep in mind that one of your `GameObjects` must have kinematic `Rigidbody` component attached.

By the way, for `OnTrigger` and `OnControllerColliderHit` events the `CharacterController` component is fine.

![image](https://user-images.githubusercontent.com/37938234/124799257-0728d080-df5d-11eb-8ea8-68bd6bcabbda.png)


### Some of my events being registered multiple times. For example, OnTriggerEnter
This cannot be fixed as events raised by Unity Physics engine, so you need to think how to fix it on your side.

You can try to create some kind of timer that is started when the event is raised and ignore events while the timer is running.
