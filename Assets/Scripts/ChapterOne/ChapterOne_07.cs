using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterOne_07 : MonoBehaviour
{
    [SerializeField] private Button m_Btn01;
    [SerializeField] private Toggle m_Tog01;
    [SerializeField] private Image m_Img01;
    [SerializeField] private UnityEvent mEvent;
    private void Start()
    {
        //对UGUI的增强

        m_Btn01.OnClickAsObservable().Subscribe(_ => { Debug.LogError("Button点击"); }).AddTo(this);
        m_Tog01.OnValueChangedAsObservable().Subscribe(val => Debug.LogError("Toggle点击" + val)).AddTo(this);

        m_Img01.OnBeginDragAsObservable().Subscribe(_ => { Debug.LogError("开始拖拽"); }).AddTo(this);
        m_Img01.OnDragAsObservable().Subscribe(eventArgs => { Debug.LogError("拖拽中"); }).AddTo(this);
        m_Img01.OnEndDragAsObservable().Subscribe(_ => { Debug.LogError("结束拖拽"); }).AddTo(this);

        mEvent.AsObservable().Subscribe(_ => { Click();  }).AddTo(this);
        mEvent?.Invoke();
    }

    public void Click()
    {
        Debug.LogError("事件");
    }
}
