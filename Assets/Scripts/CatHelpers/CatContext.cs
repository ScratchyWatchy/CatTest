using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CatContext
{
    private CatState catState;
    public string _flavorText { get; set; }
    public string _statusText { get; set; }
    public string _animator { get; set; }

    public CatContext(CatState catState)
    {
        _flavorText = "";
        _statusText = "";
        this.TransitionTo(catState);
    }

    public void StatusText(string text)
    {
        _statusText = text;
    }

    public void FlavorText(string text)
    {
        _flavorText = text;
    }

    public void Animate(string text)
    {
        _animator = text;
    }

    public void TransitionTo(CatState catState)
    {
        this.catState = catState;
        this.catState.SetContext(this);
    }

    public void FeedCaller()
    {
        this.catState.Feed();
    }

    public void PetCaller()
    {
        this.catState.Pet();
    }

    public void KickCaller()
    {
        this.catState.Kick();
    }

    public void PlayCaller()
    {
        this.catState.Play();
    }
}
