using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;
using UnityEngine.Events;

public class ChapterOne_09 : MonoBehaviour
{
    public Text m_Text;
    public Button m_Btn;
    public Toggle m_Tog;

    private Enemy m_Enemy = new Enemy(1000);
    private void Start()
    {
        //MVC的实现
        m_Btn.OnClickAsObservable().Subscribe(_ => { m_Enemy.curHp.Value -= 99; }).AddTo(this);
        m_Tog.OnValueChangedAsObservable().SubscribeToInteractable(m_Btn).AddTo(this);

        m_Enemy.curHp.SubscribeToText(m_Text);
        m_Enemy.isDead.Where(val => val).Subscribe(_=> { m_Tog.interactable = m_Btn.interactable = false; }).AddTo(this);
    }
}

public class Enemy
{
    public ReactiveProperty<long> curHp;
    public IReadOnlyReactiveProperty<bool> isDead;

    public Enemy(int hp)
    {
        curHp = new ReactiveProperty<long>(hp);
        isDead = curHp.Select(val => val <= 0).ToReactiveProperty();
    }
}
