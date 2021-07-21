using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ChapterOne_05 : MonoBehaviour
{
    private void Start()
    {
        //操作符First 第一次

        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonUp(0)).First().Subscribe(_ => { /* do something */ }).AddTo(this);
    }
}
