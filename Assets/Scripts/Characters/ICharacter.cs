﻿using Animators;

using Characters.Movement;

namespace Characters
{
    public interface ICharacter
    {
        IMovement getMovement();
        IAnimatorFacade getAnimatorFacade();
        void ChangeMovement(MovementEnum movementEnum);
        Stats getStats();
    }
}