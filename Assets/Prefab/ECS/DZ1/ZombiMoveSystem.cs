
using Unity.Entities;
using UnityEngine;

namespace Assets.Prefab.ECS
{
    class ZombiMoveSystem: ComponentSystem
    {
        private EntityQuery enityQuery;
        private Vector3 vector;
        private Quaternion angle;
        private float angleZ = 1;

        protected override void OnCreate()//условия создания
        {
            enityQuery = GetEntityQuery(ComponentType.ReadOnly<ZombiMoveComponent>());
            //base.OnCreate();
        }
        protected override void OnUpdate()//условие повторения
        {
            Entities.With(enityQuery).ForEach((Entity entity, Transform transform, ZombiMoveComponent zombiComponent)=> 
            {
                vector = transform.position;
                vector.y += zombiComponent.SpeedMove / 1000;
                angleZ -= (float)zombiComponent.SpeedMove/10;
                transform.rotation = Quaternion.Euler(0,0, angleZ);//покрутим
                transform.position = vector;//сместим
            });
            //throw new NotImplementedException();
        }
    }
}
