using UnityEngine;

namespace ServiceLocatorTestProj
{
    public interface IAudioSystem
    {
        public AudioClip GetSFX(string sfxName);
    }
}