using System;
using UnityEngine;

namespace Player
{
    [Serializable]
    public class MovementParams
    {
        [SerializeField] private LayerMask _whatIsClickable;
        [SerializeField] private float _clickRadius;
        [SerializeField] private float _speed;

        public LayerMask WhatIsClickable => _whatIsClickable;
        public float ClickRadius => _clickRadius;
        public float Speed => _speed;
    }
}