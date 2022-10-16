using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Mixin.Utils.Audio
{
    [CreateAssetMenu(fileName = "AudioClipSetup", menuName = "Mixin/Audio/AudioClipSetupSO")]
    [System.Serializable]
    public class AudioClipSetupSO : ScriptableObject
    {
        public AudioClip AudioClip;
        public AudioMixerGroup AudioMixerGroup;
        [Range(0, 1)]
        public float Volume = 1;
        public float Pitch = 1;
        public bool Loop;
        [Min(0)]
        public float FadeInDuration;
        [Min(0)]
        public float FadeOutDuration;

        public bool FadeIn => FadeInDuration > 0;
        public bool FadeOut => FadeOutDuration > 0;
        public bool Fade => FadeIn || FadeOut;
    }
}