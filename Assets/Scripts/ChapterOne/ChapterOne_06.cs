using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ChapterOne_06 : MonoBehaviour
{
    private void Start()
    {
        //Addto 跟随MonoBehavior一起销毁

        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonUp(0)).First().Subscribe(_ => { /* do something */ }).AddTo(this);
    }
}
