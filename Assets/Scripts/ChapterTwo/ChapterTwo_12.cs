using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChapterTwo_12 : MonoBehaviour
{
    void Start()
    {
        // 12.ReactiveCollection 与 ReactiveDictionary
        var progressObservable = new ScheduledNotifier<float>();
        progressObservable.Subscribe(progress =>
        {
            Debug.LogError("加载了:" + progress);
        });

        Resources.LoadAsync<GameObject>("Cube").AsAsyncOperationObservable(progressObservable).Subscribe(val => {
            Debug.LogError(val.asset.name);
        });
    }
}
