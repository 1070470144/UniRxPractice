using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_07 : MonoBehaviour
{
    void Start()
    {
        // 事件流的结束

        Observable.Timer(TimeSpan.FromSeconds(1.0f)).Subscribe(_ =>
        {
            Debug.LogError("Next");
        }, () =>
        {
            Debug.LogError("OnCompleted");
        }).AddTo(this);

        Observable.FromCoroutine(A).Subscribe(_ =>
        {
            Debug.LogError("FromCoroutine Next");
        }, () =>
        {
            Debug.LogError("FromCoroutine OnCompleted");
        }).AddTo(this);
    }

    public IEnumerator A()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.LogError("2秒后");
    }
}
