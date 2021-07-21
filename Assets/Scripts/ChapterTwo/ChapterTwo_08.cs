using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_08 : MonoBehaviour
{
    void Start()
    {
        // 多线程
       var start1 = Observable.Start(() => {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            return 10;
        });

        var start2 = Observable.Start(() => {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            return 2;
        });

        Observable.WhenAll(start1, start2).ObserveOnMainThread().Subscribe(val => {
            Debug.LogError(val[0]+"---"+val[1]);
        }).AddTo(this);
    }
}
