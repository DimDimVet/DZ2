using Unity.Entities;
using static UserInputData;

public class UserShootSystem : ComponentSystem
{
    private EntityQuery shootQuery;
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
            }
            );
    }
}
