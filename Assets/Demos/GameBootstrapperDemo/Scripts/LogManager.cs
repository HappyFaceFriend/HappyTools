using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameBootStrapperDemo
{
    public class LogManager : HappyTools.SingletonBehaviourFixed<LogManager>
    {
        [SerializeField] string message;
        public void LogMessage(string speaker)
        { 
            Debug.Log(speaker + " : " + message);
        }
    }
}
