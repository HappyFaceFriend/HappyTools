using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineDemo
{
    public abstract class PlayerState : HappyTools.StateBase
    {
        public PlayerBehaviour Player { get { return StateMachine as PlayerBehaviour; } }
    }
}