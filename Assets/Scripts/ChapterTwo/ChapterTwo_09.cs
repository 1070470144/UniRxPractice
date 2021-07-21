using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_09 : MonoBehaviour
{
    void Start()
    {
        // ObservableWWW (已过时)
        ObservableWWW.GetWWW("https://www.baidu.com").Subscribe(val => {
            Debug.LogError(val);
        }).AddTo(this);
    }
}
