using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ChapterOne_01 : MonoBehaviour
{
    private void Start()
    {
        //定时器
        Observable.Timer(TimeSpan.FromSeconds(5)).Subscribe(_ => {
            Debug.LogError("5秒后了");
        });
    }
}
