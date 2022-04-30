using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial class FPSReporterSystem : SystemBase
{
    float avg = 0f;
    int nUpdates = 0;
    int updateInterval = 500;
    float multiplier;
    protected override void OnCreate()
    {
        multiplier = 1f / updateInterval * 10;
    }
    protected override void OnUpdate() {
        float delta =
        avg = avg * (1 - multiplier) + Time.DeltaTime * multiplier;

        if(++nUpdates % updateInterval == 0) Debug.Log(avg);
    }
}
