﻿using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace traVRsal.SDK
{
    public class Mover : MonoBehaviour
    {
        public Vector2 distance = new Vector2(1f, 1f);
        public float duration = 4f;
        public Vector3 axis = Vector3.up;
        public Ease easeType = Ease.InOutSine;
        public bool loop = true;
        public LoopType loopType = LoopType.Yoyo;
        public float initialDelay;

        private IEnumerator Start()
        {
            if (initialDelay > 0) yield return new WaitForSeconds(initialDelay);

            float finalDistance = Random.Range(distance.x, distance.y);
            transform.DOLocalMove(transform.localPosition + axis * finalDistance, duration).SetLoops(loop ? -1 : 0, loopType).SetEase(easeType);
        }
    }
}