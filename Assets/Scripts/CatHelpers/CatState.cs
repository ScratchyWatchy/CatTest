using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CatState
{
    protected CatContext catContext;
    

    public void SetContext(CatContext context)
    {
        catContext = context;
    }

    public abstract void Play();
    public abstract void Feed();
    public abstract void Pet();
    public abstract void Kick();
}
