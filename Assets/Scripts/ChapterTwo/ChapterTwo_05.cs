using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_05 : MonoBehaviour
{
    void Start()
    {
        //Coroutine 的操作

        Observable.FromCoroutine(CoroutineA).Subscribe(_ =>
        {
            Debug.LogError("SubscribeA");
        }).AddTo(this);

        StartCoroutine(CoroutineB());

    }

    public IEnumerator CoroutineA()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.LogError("A");
    }
    public IEnumerator CoroutineB()
    {
        yield return Observable.Timer(TimeSpan.FromSeconds(1.0f)).ToYieldInstruction();
        Debug.LogError("B");
    }
}

