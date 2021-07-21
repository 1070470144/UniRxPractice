using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterOne_10 : MonoBehaviour
{
    private void Start()
    {
        //10.操作符 Merge

        var merge1 = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "A");
        var merge2 = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Select(_ => "B");
        Observable.Merge(merge1, merge2).Subscribe(str =>
        {
            Debug.LogError(str);
        });
    }
}

