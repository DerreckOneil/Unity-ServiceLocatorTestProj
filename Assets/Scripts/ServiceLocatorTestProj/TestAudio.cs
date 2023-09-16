using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocatorTestProj
{
    public class TestAudio : MonoBehaviour
    {
        void Start()
        {
            IAudioSystem system = ServiceLocator.Instance.GetSystem<IAudioSystem>();
            AudioClip clip = system.GetSFX("falco1e");
            Debug.Log(clip);
        }
    }
}
