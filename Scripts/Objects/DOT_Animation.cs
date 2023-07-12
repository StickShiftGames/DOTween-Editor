using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DG.Tweening.Editor
{

[CreateAssetMenu(fileName = "New Animation Clip", menuName = "DOTween/Animation Clip")]
public class DOT_Animation : SerializedScriptableObject
{
    [LabelText("Name")]
    [SerializeField] public string tweenName;
    [LabelText("Loop")]
    [SerializeField] public bool loop;

    [LabelText("Keyframes")]
    public DOT_Keyframe_I[] tweenKeyframes = new DOT_Keyframe_I[0];

    

    public DOT_Keyframe_I[] GetKeyframes()
    {
        return tweenKeyframes;
    }
}
}
