using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterOne_11 : MonoBehaviour
{
    [SerializeField] private Button m_BtnA;
    [SerializeField] private Button m_BtnB;
    [SerializeField] private Button m_BtnC;

    private void Start()
    {
        //11.实现“某个按钮点击时，使所有当前页面的按钮不可被点击”

        var buttonA = m_BtnA.OnClickAsObservable().Select(_=>"A");
        var buttonB = m_BtnB.OnClickAsObservable().Select(_=>"B");
        var buttonC = m_BtnC.OnClickAsObservable().Select(_=>"C");
        Observable.Merge(buttonA, buttonB, buttonC).First().Subscribe(str => {
            Debug.LogError(str);
        });
    }
}

