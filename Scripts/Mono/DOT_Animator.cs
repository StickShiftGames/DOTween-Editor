using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using DG.Tweening;

namespace DG.Tweening.Editor
{

[HideMonoScript]
public class DOT_Animator : MonoBehaviour
{
    //Clips
    [SerializeField] private DOT_AnimationController controller;


    [SerializeField] private DOT_ClipHolder[] clips;

    //Animation sequences
    private Dictionary<string, Sequence> tweens = new Dictionary<string, Sequence>();

    [Button]
    private void BuildList()
    {
        clips = new DOT_ClipHolder[controller.tweenClips.Length];

        for(int i = 0; i < controller.tweenClips.Length; i++)
        {
            clips[i] = new DOT_ClipHolder(controller.GetClip(i));
        }
    }

    void Awake()
    {
        BuildSequences();
    }

    private void BuildSequences()
    {
        for(int i = 0; i < clips.Length; i++)
        {
            tweens.Add(clips[i].Name, clips[i].BuildSequence());
        }
    }

    // Play sequence by index
    public void PlaySequence(int index)
    {
        if(index > tweens.Count)
            Debug.LogError("Index out of bounds");

        tweens.ElementAt(index).Value.Restart();

        tweens.ElementAt(index).Value.PlayForward();
        /*
        if(!reverse)
            tweens.ElementAt(index).Value.PlayForward();
        else
            tweens.ElementAt(index).Value.PlayBackwards();
        */
    }

    // Play sequence by name
    public void PlaySequence(string name, bool reverse = false)
    {
        if(tweens[name] == null)
            Debug.LogError("Tween name " + name + " dose not exist");

        tweens[name].Restart();

        if(!reverse)
            tweens[name].PlayForward();
        else
            tweens[name].PlayBackwards();
    }

    //Pause sequence by index
    public void PauseSequence(int index)
    {
        if(index > tweens.Count)
            Debug.LogError("Index out of bounds");
            
        tweens.ElementAt(index).Value.Pause();
    }

    //Pause sequence by name
    public void PauseSequence(string name)
    {
        if(tweens[name] == null)
            Debug.LogError("Tween name " + name + " dose not exist");
            
        tweens[name].Pause();
    }
}
}


