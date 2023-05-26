
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Prefab.ECS.PersDZ2;
using Unity.Mathematics;

public class TranslationAnim : MonoBehaviour
{
    private Animator animator;
    private float refFloat=0.01f;
    void Start()
    {
        animator = GetComponent<Animator>();
        UserMoveSystem.AnimMoveEvent += GetMove;//подпишемся на событие радара
        UserPullSystem.AnimPullEvent += GetPull;
    }

    private void GetMove(float2 currentMove)
    {
        if (Mathf.Abs(currentMove.x)>= refFloat | Mathf.Abs(currentMove.y) >= refFloat )
        {
            animator.SetFloat("SpeedEnemy", 1);
        }
        else
        {
            animator.SetFloat("SpeedEnemy", 0);
        }
    }
    private void GetPull(bool currentPull)
    {
        if (currentPull)
        {
            animator.SetBool("Jamp", currentPull); 
        }
        else
        {
            animator.SetBool("Jamp", false);
        }
    }
}
