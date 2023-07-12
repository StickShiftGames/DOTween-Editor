using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using DG.Tweening;

namespace DG.Tweening.Editor
{

//Interface for the animation controler to get animation clip
public interface DOT_Keyframe_I
{
    public bool GetJoinState();
    public Tween GetAnimation(GameObject tweenObject);
    public bool CheckProperComponent(GameObject testObject);
}

//Base class with values all tween animations share
public class DOT_Keyframe_Base
{
    [HorizontalGroup("row1")]
    [LabelText("Duration")]
    [SerializeField] protected float tweenDuration;
    [HorizontalGroup("row1")]
    [LabelText("Ease")]
    [SerializeField] protected Ease tweenEase = Ease.Linear;
    [HorizontalGroup("row1")]
    [LabelText("Join")]
    [SerializeField] protected bool tweenJoin;

    public bool GetJoinState()
    {
        return tweenJoin;
    }
}


//Move to position animation
public class DOT_DOMove: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenPostion;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<Transform>().DOMove(tweenPostion, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<Transform>() != null;
    }
}

//Set rotation animaton
public class DOT_DORotate_3D: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenRotation;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<Transform>().DORotate(tweenRotation, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<Transform>() != null;
    }
}

//Set size animation
public class DOT_DOScale: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenScale;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<Transform>().DOScale(tweenScale, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<Transform>() != null;
    }
}

//Move to position animation
public class DOT_DOAnchorPos: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenPostion;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<RectTransform>().DOAnchorPos(tweenPostion, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<RectTransform>() != null;
    }
}

//Set rotation animaton
public class DOT_DORotate_2D: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenRotation;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<RectTransform>().DORotate(tweenRotation, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<RectTransform>() != null;
    }
}


//Set size animation
public class DOT_DOSizeDelta: DOT_Keyframe_Base, DOT_Keyframe_I
{
    [PropertyOrder(-3)]
    [SerializeField] protected Vector3 tweenScale;

    public Tween GetAnimation(GameObject tweenObject)
    {
        if(!CheckProperComponent(tweenObject))
            Debug.LogError("Required Componint Missing.");

        Tween tween = null;
        tween = tweenObject.GetComponent<RectTransform>().DOSizeDelta(tweenScale, tweenDuration).SetEase(tweenEase);
        return tween;
    }

    public bool CheckProperComponent(GameObject testObject)
    {
        return testObject.GetComponent<RectTransform>() != null;
    }
}
}