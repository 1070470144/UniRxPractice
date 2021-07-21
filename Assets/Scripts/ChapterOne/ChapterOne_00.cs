using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ChapterOne_00 : MonoBehaviour
{
    private void Start()
    {
        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).First().Subscribe(_ => {
            Debug.LogError("处理第一次点击");
        });
    }
}
