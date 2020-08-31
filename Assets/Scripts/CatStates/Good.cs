using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good : CatState
{
    public Good()
    {
    }

    public override void Feed()
    {
        this.catContext.TransitionTo(new Great());
        this.catContext.StatusText("Great");
        this.catContext.FlavorText("Быстро все съедает");
        this.catContext.Animate("FastEat");  
    }

    public override void Pet()
    {
        this.catContext.TransitionTo(new Great());
        this.catContext.StatusText("Great");
        this.catContext.FlavorText("Мурлычет");
        this.catContext.Animate("Purr");
        
    }

    public override void Kick()
    {
        this.catContext.TransitionTo(new Bad());
        this.catContext.StatusText("Bad");
        this.catContext.FlavorText("Убегает на ковер и писает");
        this.catContext.Animate("RunAndPee");
       
    }

    public override void Play()
    {
        this.catContext.TransitionTo(new Great());
        this.catContext.StatusText("Great");
        this.catContext.FlavorText("Медленно бегает за мячиком");
        this.catContext.Animate("SlowPlay");

    }
}
