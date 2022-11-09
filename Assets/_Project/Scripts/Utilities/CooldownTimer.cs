﻿using System;
using UnityEngine;

namespace com.N8Dev.Allete.Utilities
{
    [Serializable]
    public class CooldownTimer
    {
        //Event
        public event Action OnCooledDown;
        
        //Cooldown
        [Range(0.1f, 100f)] [SerializeField] private float CooldownTime = 0.3f;
        private bool isCooledDown = true;

        public bool IsCooledDown() => isCooledDown;

        public void StartCooldown()
        {
            isCooledDown = false;
            this.Invoke(() =>
            {
                isCooledDown = true;
                OnCooledDown?.Invoke();
            }, CooldownTime);
        }
    }
}