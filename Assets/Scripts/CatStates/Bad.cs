using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : CatState
{
    public Bad()
    {
    }

    public override void Feed()
    {
        this.catContext.TransitionTo(new Good());
        this.catContext.StatusText("Good");
        this.catContext.FlavorText("Все съедает, но если в это время подойти - поцарапает");
        this.catContext.Animate("DefensiveEating");

    }

    public override void Pet()
    {
        this.catContext.FlavorText("Царапает");
        this.catContext.Animate("Scratch");
    }

    public override void Kick()
    {
        this.catContext.FlavorText("Прыгает и кусает за правое ухо");
        this.catContext.Animate("JumpAndBite");
    }

    public override void Play()
    {
        this.catContext.FlavorText("Сидит на месте");
        this.catContext.Animate("Idle");
    }
}
