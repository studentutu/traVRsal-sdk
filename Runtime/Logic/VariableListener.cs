﻿using System.Collections.Generic;
using UnityEngine;

namespace traVRsal.SDK
{
    [AddComponentMenu("traVRsal/Variable Listener")]
    public class VariableListener : ExecutorConfig
    {
        public enum Action
        {
            Assignments_Only = 6,
            Call_Reactors = 3,
            Activate_Object = 0,
            Activate_Component = 1,
            Activate_Emission = 2,
            GameState_Game = 4,
            GameState_Menu = 5,
            Nothing = 7
        }

        [Header("Configuration")] [Tooltip("Variable to listen to. If left empty will use the variable defined from the outside, e.g. through Tiled.")]
        public string variable;

        [Range(0, 5)] public int variableChannel;

        public bool invert;

        [Header("Action")] public Action action = Action.Assignments_Only;
        public GameObject targetObject;
        public Behaviour component;

        [Header("Static Assignments")] public List<GameObject> enabledObjects;
        public List<GameObject> disabledObjects;
        public List<Behaviour> enabledComponents;
        public List<Behaviour> disabledComponents;
        public List<Collider> enabledColliders;
        public List<Collider> disabledColliders;
    }
}