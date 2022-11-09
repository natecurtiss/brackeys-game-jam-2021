﻿using System;
using com.N8Dev.Allete.AudioManagement;
using DG.Tweening;
using UnityEngine;

namespace com.N8Dev.Allete.Movement
{
    [Serializable]
    public class Jumping : IMovementView
    {
        //Jumping
        [Header("Jumping")]
        [SerializeField] private Transform Transform;
        [Range(0.1f, 1f)] [SerializeField] private float Power = 0.3f;
        [Range(0.1f, 1f)] [SerializeField] private float Duration = 0.3f;
        
        //Sound
        [Header("Sound")]
        [SerializeField] private Sound Sound;

        public void ApplyMovement(Vector3 _targetPos)
        {
            Transform.DOJump(_targetPos, Power, 1, Duration);
            Sound.Play();
        }
    }
}