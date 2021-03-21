﻿using UnityEngine;

namespace traVRsal.SDK
{
    public class MovingPlatform : ExecutorConfig
    {
        public enum Trigger
        {
            Variable = 0,
            Automatic = 1
        }

        public enum State
        {
            Home = 0,
            MovingToTarget = 1,
            Target = 2,
            MovingToHome = 3
        }

        public enum AutoMovement
        {
            None = 0,
            AutoReturn = 1,
            MoveToPlayer = 2,
            PingPong = 3
        }

        public enum TargetPositionMode
        {
            Automatic = 0,
            Manual = 1,
            Location = 2,
            Floor = 3
        }

        public TargetPositionMode targetPositionMode = TargetPositionMode.Automatic;
        public Vector3 targetPosition;
        public string targetLocation;
        public int targetFloor;

        [Tooltip("Defines when a platform should move, either automatically or based on a variable.")]
        public Trigger trigger = Trigger.Variable;

        [Tooltip("Defines how a platform should automatically move: Return to the original position, move to the floor the player is on or continuously move between home and target position.")]
        public AutoMovement autoMovement = AutoMovement.None;

        public float duration = 3f;
        public float initialPause = 2f;
        public float stationPause = 2f;
        public float playerCheckInterval = 2f;
    }
}