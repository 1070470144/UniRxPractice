using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterOne_08 : MonoBehaviour
{
    private ReactiveProperty<int> m_Age = new ReactiveProperty<int>();
    private void Start()
    {
        //响应式属性

        m_Age.Subscribe(val => Debug.LogError(val)).AddTo(this);

        m_Age.Value = 10;
    }
}
