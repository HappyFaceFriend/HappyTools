using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineDemo
{
    public class PlayerBehaviour : HappyTools.StateMachineBase
    {
        [SerializeField] int _attackPower;

        public int AttackPower { get { return _attackPower; } }
        protected override void Start()
        {
            base.Start();
            Animator.ResetTrigger("Idle");
        }
        protected override void Update()
        {
            base.Update();

        }
    }
}