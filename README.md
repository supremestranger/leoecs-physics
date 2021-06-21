# LeoECS physics
This is a simple Unity physics events emitter for Leopotam ECS framework.
No more need to create MonoBehaviour scripts for physics events handling - just follow a few simple steps to do it with this tool.

# Installation
You can install this repository via `Package Manager -> Add package from git URL...`

Fill the opened field with
```
https://github.com/supremestranger/leoecs-physics.git
```

If you can't / don't want to use Package Manage or Git, you can just download the repository and add to your project.

# Checkers
Checker is a `MonoBehaviour` script that contains a specific Unity physics event method.

You need to attach a concrete Checker to any `GameObject` that emits any Unity physics events.

## Here is the list of all Checkers:
* `OnTriggerEnterChecker` - responsible for `OnTriggerEnter` event
* `OnTriggerStayChecker` - responsible for `OnTriggerStay` event
* `OnTriggerExitChecker` - responsible for `OnTriggerExit` event
* `OnCollisionEnterChecker` - responsible for `OnCollisionEnter` event
* `OnCollisionStayChecker` - responsible for `OnCollisionStay` event
* `OnCollisionExitChecker` - responsible for `OnCollisionExit` event
* `OnControllerColliderHitChecker` - responsible for `OnControllerColliderHit` (only for `Character Controller` objects) event

# Events
When some event is raised, it creates a new entity-event with a specific component like `OnCollisionEnterEvent` or `OnTriggerStayEvent`.

The component contains only two `GameObject` fields: 
* `thisGO` - the one that has a `Checker` attached 
* `otherGO` - the other GO.

But before diving into handling all of this stuff, you need to initialize the `EcsPhysicsEventsEmitter` in your `Startup` script like this:

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
        EcsPhysicsEventsEmitter.ecsWorld = ecsWorld;
            
        ecsSystems
            // your systems
            .Add(new TestSystem())
            .Init();
    }

    private void Update()
    {
        ecsSystems?.Run ();
    }

    private void OnDestroy()
    {
        if (ecsSystems != null)
        {
            // don't forget to get rid of this reference.
            EcsPhysicsEventsEmitter.ecsWorld = null;
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
            ref var eventData = ref filter2.Get1(i);

            eventData.otherGO.SetActive(false);
         }
     }
 }
```
