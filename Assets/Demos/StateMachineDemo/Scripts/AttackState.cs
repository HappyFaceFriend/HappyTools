using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineDemo
{
    public class AttackState : PlayerState
    {
        protected override void OnEnter()
        {
            StartCoroutine(Attack());
        }
        IEnumerator Attack()
        {
            Debug.Log("Attack with power " + Player.AttackPower);

            if (Player.PreviousState is WalkState)
                Debug.Log("Attack during walk");
            else
                Debug.Log("Attack during idle");

            yield return new WaitForSeconds(0.5f);
            ChangeState<IdleState>();
        }
        protected override void OnExit()
        {
        }

        protected override void OnUpdate()
        {
        }
    }
}