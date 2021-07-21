using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ChapterOne_02 : MonoBehaviour
{
    private void Start()
    {
        //独立的Update

        Observable.EveryUpdate().Subscribe(_ => {
            Debug.LogError("A");
        }).AddTo(this);

        Observable.EveryUpdate().Subscribe(_ => {
            Debug.LogError("B");
        }).AddTo(this);

        Observable.EveryUpdate().Subscribe(_ => {
            Debug.LogError("C");
        }).AddTo(this);
    }
}
