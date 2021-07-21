using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_11 : MonoBehaviour
{
    void Start()
    {
        // 11.ReactiveCollection 与 ReactiveDictionary

        ReactiveCollection<int> intList = new ReactiveCollection<int>();

        intList.ObserveAdd().Subscribe(val =>
        {
            Debug.LogError("增加的值:" + val);
        });

        intList.ObserveRemove().Subscribe(val =>
        {
            Debug.LogError("减少的值:" + val);
        });

        intList.ObserveReplace().Subscribe(val =>
        {
            Debug.LogError("替换的值:" + val);
        });

        intList.ObserveMove().Subscribe(val =>
        {
            Debug.LogError("移动的值:" + val);
        });

        intList.ObserveCountChanged().Subscribe(val =>
        {
            Debug.LogError("值数量改变:" + val);
        });

        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);

        intList.Remove(1);

        intList.Move(0, 1);

        intList[0] = 10;


        ReactiveDictionary<string, string> mLanguageCode = new ReactiveDictionary<string, string>() { { "en", "英语" }, { "cn", "中⽂" } };

        mLanguageCode.ObserveAdd().Subscribe(val =>
        {
            Debug.LogError("增加的值:" + val);
        });

        mLanguageCode.ObserveRemove().Subscribe(val =>
        {
            Debug.LogError("减少的值:" + val);
        });

        mLanguageCode.ObserveReplace().Subscribe(val =>
        {
            Debug.LogError("替换的值:" + val);
        });

        mLanguageCode.ObserveCountChanged().Subscribe(val =>
        {
            Debug.LogError("值数量改变:" + val);
        });

        mLanguageCode.Add("1","1");
        mLanguageCode.Add("2", "2");
        mLanguageCode.Add("3", "3");
        mLanguageCode.Add("4", "4");

        mLanguageCode.Remove("1");

        mLanguageCode["1"] = "10";
    }
}
