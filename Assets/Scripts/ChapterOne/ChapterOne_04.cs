using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ChapterOne_04 : MonoBehaviour
{
    private void Start()
    {
        //操作符Whwre  过滤

        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonUp(0)).Subscribe(_ =>{}).AddTo(this);
    }
}
