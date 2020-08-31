using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Great : CatState
{
    public Great()
    {
    }
    public override void Feed()
    {
        this.catContext.FlavorText("Быстро все съедает");
        this.catContext.Animate("FastEat");
    }

    public override void Pet()
    {
        this.catContext.FlavorText("Мурлычет и виляет хвостом, как собака, но это кошка, всегда был уверен, что кошки хвостом не виляют");
        this.catContext.Animate("PurrAndWag");
    }

    public override void Kick()
    {
        this.catContext.TransitionTo(new Bad());
        this.catContext.StatusText("Bad");
        this.catContext.FlavorText("Убегает в другую комнату");
        this.catContext.Animate("RunAway");

    }

    public override void Play()
    {
        this.catContext.FlavorText("Носится как угорелая");
        this.catContext.Animate("FastPlay");
    }
}
