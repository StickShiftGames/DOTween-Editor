using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DG.Tweening.Editor
{

[CreateAssetMenu(fileName = "New Animation Controller", menuName = "DOTween/Animation Controller")]
public class DOT_AnimationController : SerializedScriptableObject
{
    [LabelText("Clips")]
    public DOT_Animation[] tweenClips;

    public DOT_Animation GetClip(int index)
    {
        return tweenClips[index];
    }
}
}