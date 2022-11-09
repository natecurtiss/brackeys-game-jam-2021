﻿using UnityEngine;

namespace com.N8Dev.Allete.Sizing
{
    public class PlayerSizeable : MonoBehaviour, ISizeable
    {
        //Player Sizes
        [SerializeField] private Transform[] PlayerSizes;
        [SerializeField] private Sizes CurrentSize;

        public int GetID() => GetInstanceID();
        
        public Sizes GetSize() => CurrentSize;

        public Transform GetLowerSize() => PlayerSizes[Mathf.Min((int) CurrentSize + 1, PlayerSizes.Length)];

        public Transform GetBiggerSize() => PlayerSizes[Mathf.Max(0, (int) CurrentSize - 1)];
    }

    public enum Sizes
    {
        Large,
        Medium,
        Small
    }
}