using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using DG.Tweening;

/*
    Contains all classes related to the Amimator Functionality
*/

namespace DG.Tweening.Editor
{ 

[System.Serializable]
public class DOT_ClipHolder
{
    [ReadOnly]
    [SerializeField] private DOT_Animation clip;

    [ReadOnly]
    [SerializeField] private string name;
    public string Name
    {
        get { return name; }
    }
    

    [ListDrawerSettings(IsReadOnly = true)]
    [SerializeField] private GameObject[] objects;

    public DOT_ClipHolder(DOT_Animation _clip)
    {
        clip = _clip;
        name = clip.name;
        objects = new GameObject[clip.GetKeyframes().Length];
    }

    public Sequence BuildSequence()
    {
        DOT_Keyframe_I[] frames = clip.GetKeyframes();

        Sequence newTweenSequence  = DOTween.Sequence();
        newTweenSequence.Pause();
        newTweenSequence.SetAutoKill(false);

        for(int i = 0; i < frames.Length; i++)
        {
            if(frames[i].GetJoinState())
            {
                newTweenSequence.Join(frames[i].GetAnimation(objects[i]));
            }
            else
            {
                newTweenSequence.Append(frames[i].GetAnimation(objects[i]));
            }
        }

        if(clip.loop)
            newTweenSequence.SetLoops(-1);

        return newTweenSequence;
    }

    public void CheckComponents()
    {
        DOT_Keyframe_I[] frames = clip.GetKeyframes();

        for(int j = 0; j < frames.Length; j++)
        {
            if(!frames[j].CheckProperComponent(objects[j]))
                Debug.Log("Object at index " + j + " in missing a required component");
        }
    }
} 
}

