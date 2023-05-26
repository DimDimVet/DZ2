using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using static UserInputData;

public class UserShootSystem : ComponentSystem
{
    private EntityQuery shootQuery;
    //event
    //public delegate void AnimMove(float2 moveSpeed);
    //public static event AnimMove AnimMoveEvent;

    protected override void OnCreate()
    {
        shootQuery = GetEntityQuery(ComponentType.ReadOnly<ShootDataStr>(),
                                   ComponentType.ReadOnly<UserInputData>());
    }

    protected override void OnUpdate()
    {
        Entities.With(shootQuery).ForEach
            (
            (Entity entity, UserInputData userInput, ref InputDataStr inputData) =>
            {
                if (inputData.Shoot>0f && userInput.ShootAction!=null && userInput.ShootAction is IAbility ability)
                {
                    ability.Execute();
                }
                //AnimMoveEvent?.Invoke(inputData.Move);
            }
            );
    }
}
