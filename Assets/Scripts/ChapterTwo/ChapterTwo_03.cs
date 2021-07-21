using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterTwo_03 : MonoBehaviour
{
    [SerializeField] Button mButton;
    [SerializeField] Toggle mToggle;
    [SerializeField] Scrollbar mScrollbar;
    [SerializeField] ScrollRect mScrollRect;
    [SerializeField] Slider mSlider;
    [SerializeField] InputField mInputField;
    void Start()
    {
        //生命周期

        Observable.EveryFixedUpdate().Subscribe(_ => { });
        Observable.EveryEndOfFrame().Subscribe(_ => { });
        Observable.EveryLateUpdate().Subscribe(_ => { });
        Observable.EveryAfterUpdate().Subscribe(_ => { });
        Observable.EveryApplicationPause().Subscribe(paused => { });
        Observable.EveryApplicationFocus().Subscribe(focused => { });

        // Trigger
        this.UpdateAsObservable().Subscribe(_ => { });  //等同于Observable.EveryUpdate().Subscribe(_ => { }).AddTo(this)
        this.OnDestroyAsObservable().Subscribe(_ => { });
        this.FixedUpdateAsObservable().Subscribe(_ => { });
        this.LateUpdateAsObservable().Subscribe(_ => { });
        this.UpdateAsObservable().Subscribe(_ => { });

        this.OnCollisionEnter2DAsObservable().Subscribe(_ => { });
        this.OnCollisionStay2DAsObservable().Subscribe(_ => { });
        this.OnCollisionExit2DAsObservable().Subscribe(_ => { });

        this.OnCollisionEnterAsObservable().Subscribe(_ => { });
        this.OnCollisionStayAsObservable().Subscribe(_ => { });
        this.OnCollisionExitAsObservable().Subscribe(_ => { });

        this.OnEnableAsObservable().Subscribe(_ => { });
        this.OnDisableAsObservable().Subscribe(_ => { });


        //具体参考
        //ObservableTriggerExtensions.Component.cs
    }
}

