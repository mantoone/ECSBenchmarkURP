using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial class StartupSystem : SystemBase
{
    public GameObject createGameObj;
    private EntityManager entityManager;
    private World defaultWorld;

    protected override void OnCreate()
    {
        defaultWorld = World.DefaultGameObjectInjectionWorld;
        entityManager = defaultWorld.EntityManager;

        var entityToCreate = entityManager.CreateArchetype(
            typeof(Translation),
            typeof(Direction),
            typeof(ComflabulationComponent)
        );

        int numberOfEntities = 10_000_000;

        Debug.Log("Number of entities: " + numberOfEntities.ToString());

        for(int i = 0; i < numberOfEntities; ++i) {
            Entity ent = entityManager.CreateEntity(entityToCreate);
            entityManager.SetComponentData(ent, new Direction { x = 1f, y = 1f });
        }

    }
    protected override void OnUpdate() {}
}
