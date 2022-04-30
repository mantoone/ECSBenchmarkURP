using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public partial class MovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        // Assign values to local variables captured in your job here, so that it has
        // everything it needs to do its work when it runs later.
        // For example,
        float dt = Time.DeltaTime;

        // This declares a new kind of job, which is a unit of work to do.
        // The job is declared as an Entities.ForEach with the target components as parameters,
        // meaning it will process all entities in the world that have both
        // Translation and Rotation components. Change it to process the component
        // types you want.
        
        
        /*
        Entities.ForEach((ref Translation translation, in Direction dir) => {
            // Implement the work to perform for each entity here.
            // You should only access data that is local or that is a
            // field on this job. Note that the 'rotation' parameter is
            // marked as 'in', which means it cannot be modified,
            // but allows this job to run in parallel with other jobs
            // that want to read Rotation component data.
            // For example,
            translation.Value[0] += dir.x * dt;
            translation.Value[1] += dir.y * dt;
        }).Run();
        */

        new TransJob { dt = Time.DeltaTime }.Run();
    }

    [BurstCompile]
    private partial struct TransJob : IJobEntity {
        public float dt;
        public void Execute (ref Translation translation, in Direction dir){
            translation.Value[0] += dir.x * dt;
            translation.Value[1] += dir.y * dt;
        }
    }
}
