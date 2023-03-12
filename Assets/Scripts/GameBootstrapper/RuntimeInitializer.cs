using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyTools
{
    public static class RuntimeInitializer
    {
        const string BOOTSTRAPPER_PREFAB_PATH = "GameBootstrapper_"; //change this to GameBootstrapper  (remove the _ )

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void InstantiateBootstrapper()
        {
            if (BOOTSTRAPPER_PREFAB_PATH == "")
                return;
            Object resourceOb = Resources.Load(BOOTSTRAPPER_PREFAB_PATH);

            if (resourceOb == null)
            {
                Debug.LogWarning("Failed to find bootstrapper at: " + BOOTSTRAPPER_PREFAB_PATH + ".\nChange the path by changing BOOTSTRAPPER_PREFAB_PATH at RuntimeInitializer.cs. It should be relative to the Resources directory.\nIf you don't want to use a bootstrapper, set the path to \"\".\n");
            }
            else
            {
                GameObject ob = Object.Instantiate(resourceOb) as GameObject;
                Object.DontDestroyOnLoad(ob);
                ob.GetComponent<GameBootstrapper>().InitGame();
            }
        }
    }
}