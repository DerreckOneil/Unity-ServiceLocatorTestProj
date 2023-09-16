using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocatorTestProj
{
    public class AudioSystem : MonoBehaviour, IAudioSystem
    {
        [SerializeField] private List<AudioClip> clips = new();

        public AudioClip GetSFX(string sfxName)
        {
            foreach(AudioClip clip in clips)
                if(clip.name == sfxName)
                    return clip;
            return null;
        }
    }
}
