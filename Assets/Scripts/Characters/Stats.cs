﻿using UnityEngine;

namespace Characters
{
    public class Stats : MonoBehaviour
    {
        [Header("Movement speed")] public float walkSpeed = 6f;
        public float runSpeed = 10f;
        public float acceleration = 30f;
        public float airSpeed = 5f;
        public float rotationSpeed = 0.1f;
        public float crouchSpeed = 6f;
        public float slidingSpeed = 15f;
        [Header("Jumping/falling")] public float jumpForce = 10f;
        public float additionalGravityForce = 20f;
        public int maxJumps = 2;
        public float maxDownVelocity = -20f;
    }
}