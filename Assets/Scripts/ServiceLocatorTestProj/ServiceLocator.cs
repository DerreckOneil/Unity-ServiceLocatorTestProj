using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocatorTestProj
{
    public class ServiceLocator : MonoBehaviour
    {
        private static ServiceLocator instance;
        public static ServiceLocator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = Resources.Load<ServiceLocator>("Service Locator"); //Refers to the prefab in the resources folder.
                }
                return instance;
            }
        }

        public T GetSystem<T>() => GetComponentInChildren<T>();
    }

}
