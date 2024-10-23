using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

using System;
public class TextScale : MonoBehaviour
{
private Vector3 _originscale;
private Vector3 _Scaleto;
public float multiplier;
void Start()
{
    _originscale = transform.localScale;
    _Scaleto = _originscale * multiplier; 
    transform.DOScale(_Scaleto, 2.0f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
}
}
