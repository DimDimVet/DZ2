using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using static UserInputData;

namespace Assets.Prefab.ECS.PersDZ2
{
    public class UserMoveSystem : ComponentSystem
    {
        private EntityQuery moveQuery;
        //event
        public delegate void AnimMove(float2 moveSpeed);
        public static event AnimMove AnimMoveEvent;

        protected override void OnCreate()
        {
            moveQuery = GetEntityQuery(ComponentType.ReadOnly<InputDataStr>(),
                                       ComponentType.ReadOnly<MoveDataStr>(),
                                       ComponentType.ReadOnly<Transform>());
        }

        protected override void OnUpdate()
        {
            Entities.With(moveQuery).ForEach
                (
                (Entity entity, Transform transform, ref InputDataStr inputData, ref MoveDataStr moveData) =>
                {
                    Vector3 currentPosition = transform.position;
                    currentPosition += new Vector3(inputData.Move.x * moveData.MoveSpeed,
                                                   0,
                                                   inputData.Move.y * moveData.MoveSpeed);
                    transform.position = currentPosition;

                    AnimMoveEvent?.Invoke(inputData.Move);
                }
                );

        }
    }
}
