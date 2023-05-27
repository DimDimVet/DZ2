using Unity.Entities;
using static UserInputData;

public class UserPullSystem : ComponentSystem
{
    private EntityQuery pullQuery;
    //event
    public delegate void AnimMovePull(bool movePull);
    public static event AnimMovePull AnimPullEvent;

    protected override void OnCreate()
    {
        pullQuery = GetEntityQuery(ComponentType.ReadOnly<PullDataStr>(),
                                   ComponentType.ReadOnly<UserInputData>());
    }

    protected override void OnUpdate()
    {
        Entities.With(pullQuery).ForEach
            (
            (Entity entity, UserInputData userInput, ref InputDataStr inputData) =>
            {
                if (inputData.Pull >0 && userInput.PullAction != null && userInput.PullAction is IPull pull)
                {
                    pull.Jamp();
                    AnimPullEvent?.Invoke(true);
                }
                else
                {
                    AnimPullEvent?.Invoke(false);
                }
            }
            );
    }
}