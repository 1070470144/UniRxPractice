using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_06 : MonoBehaviour
{
    [SerializeField] Button mButtonA;
    [SerializeField] Button mButtonB;
    [SerializeField] Button mButtonC;
    void Start()
    {
        //WhenAll 的操作
        var a = Observable.FromCoroutine(A);
        var b = Observable.FromCoroutine(B);

        Observable.WhenAll(a, b).Subscribe(x=> { 
             Debug.LogError("Subscribe");
        });

        var aStream = mButtonA.OnClickAsObservable().First();
        var bStream = mButtonB.OnClickAsObservable().First();
        var cStream = mButtonC.OnClickAsObservable().First();
        Observable.WhenAll(
        aStream,
        bStream,
        cStream)
        .Subscribe(_ =>
        {
            Debug.Log("clicked");
        }).AddTo(this);

    }

    public IEnumerator A()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.LogError("A");
    }
    
    public IEnumerator B()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.LogError("B");

    }
}

