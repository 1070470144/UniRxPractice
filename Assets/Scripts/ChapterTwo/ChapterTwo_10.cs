using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_10 : MonoBehaviour
{
    void Start()
    {
        // 10.ReactiveCommand
        ReactiveCommand reactiveCommand = new ReactiveCommand();

        reactiveCommand.Subscribe(_ => { Debug.LogError("###"); });

        reactiveCommand.Execute();

        var leftClick = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => true);
        var rightClick = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Select(_ => false);

        var merge = Observable.Merge(leftClick, rightClick);

        ReactiveCommand mergeReactiveCommand = new ReactiveCommand(merge,false);

        mergeReactiveCommand.Subscribe(val =>
        {
            Debug.LogError("###"+ val);
        });

        Observable.EveryUpdate().Subscribe(_ => {
            mergeReactiveCommand.Execute();
        });
    }
}
