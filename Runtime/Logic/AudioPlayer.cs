﻿using UnityEngine;

namespace traVRsal.SDK
{
    [AddComponentMenu("traVRsal/Audio Player")]
    public class AudioPlayer : MonoBehaviour, IVariableReactor
    {
        [Range(0, 5)] public int variableChannel;

        [Header("When Variable Is True")] [Tooltip("Sound to play when the variable is true.")]
        public AudioSource audioActive;

        public bool playActiveOnlyOnce;

        [Header("When Variable Is False")] [Tooltip("Sound to play when the variable is false.")]
        public AudioSource audioInactive;

        public bool playInactiveOnlyOnce;

        private bool activeTriggered;
        private bool inactiveTriggered;

        public void VariableChanged(Variable variable, bool condition, bool initialCall = false)
        {
            if (condition)
            {
                if (!playActiveOnlyOnce || !activeTriggered)
                {
                    if (audioActive != null) audioActive.Play();
                }
                activeTriggered = true;
            }
            else
            {
                if (!playInactiveOnlyOnce || !inactiveTriggered)
                {
                    if (audioInactive != null) audioInactive.Play();
                }
                inactiveTriggered = true;
            }
        }

        public int GetVariableChannel()
        {
            return variableChannel;
        }
    }
}