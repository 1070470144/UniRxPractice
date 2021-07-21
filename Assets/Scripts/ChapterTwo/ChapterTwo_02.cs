using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_02 : MonoBehaviour
{
    [SerializeField] Button mButton;
    [SerializeField] Toggle mToggle;
    [SerializeField] Scrollbar mScrollbar;
    [SerializeField] ScrollRect mScrollRect;
    [SerializeField] Slider mSlider;
    [SerializeField] InputField mInputField;
    void Start()
    {
        //UGUI增强

        mButton.OnClickAsObservable().Subscribe(_ => Debug.Log("On Button Clicked"));
        mToggle.OnValueChangedAsObservable().Subscribe(on => Debug.Log("Toggle " +
        on));
        mScrollbar.OnValueChangedAsObservable().Subscribe(scrollValue =>
        Debug.Log("Scrolled " + scrollValue));
        mScrollRect.OnValueChangedAsObservable().Subscribe(scrollValue =>
        Debug.Log("Scrolled " + scrollValue));
        mSlider.OnValueChangedAsObservable().Subscribe(sliderValue =>
        Debug.Log("Slider Value " + sliderValue));
        mInputField.OnValueChangedAsObservable().Subscribe(inputText =>
        Debug.Log("Input Text: " + inputText));
        mInputField.OnEndEditAsObservable().Subscribe(result => Debug.Log("Result :" +
        result));
    }
}

