using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Unity.Entities;

public class UserInputData : MonoBehaviour,IConvertGameObjectToEntity
{
    public float Speed;
    public MonoBehaviour ShootAction;
    public MonoBehaviour PullAction;
    public void Convert(Entity entity, EntityManager entityManager, 
                        GameObjectConversionSystem conversionSystem)
    {
        entityManager.AddComponentData(entity,new InputDataStr());
        entityManager.AddComponentData(entity, new MoveDataStr()
        {
            MoveSpeed=Speed/100
        });

        if (ShootAction !=null & ShootAction is IAbility)
        {
            entityManager.AddComponentData(entity,new ShootDataStr());
        }

        if (PullAction !=null & PullAction is IPull)
        {
            entityManager.AddComponentData(entity, new PullDataStr());
        }
        
    }

    ///structure
    public struct InputDataStr : IComponentData
    {
        public float2 Move;
        public float Shoot;
        public float Pull;
    }

    public struct MoveDataStr : IComponentData
    {
        public float MoveSpeed;
    }

    public struct ShootDataStr : IComponentData
    {
        //
    }
    public struct PullDataStr : IComponentData
    {
        //
    }
}
