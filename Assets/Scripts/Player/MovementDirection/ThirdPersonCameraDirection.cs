﻿using ErbiumCamera;
using General;
using UnityEngine;

namespace Player.MovementDirection
{
    //used for getting camera direction
    public class ThirdPersonCameraDirection : IMovementDirection
    {
        public Vector3 GetDirection()
        {
            Vector3 forward = CameraManager.getCameraForwardDirectionNormalized();
            Vector3 right = CameraManager.getCameraRightDirectionNormalized();
            return forward * InputManager.getVerInput() + right * InputManager.getHorInput();
        }
    }
}