using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.UI;

public class CatStateManger : MonoBehaviour
{
    public Text flavorText;
    public Text statusText;
    public Animator animator;
    public CatContext catContext;

    void Awake()
    {
        catContext = new CatContext(new Good());
    }

    void Start()
    {
        PetEntryPoint();
    }

    public void PetEntryPoint()
    {
        catContext.PetCaller();
        UpdateDisplay();
    }

    public void FeedEntryPoint()
    {
        catContext.FeedCaller();
        UpdateDisplay();
    }

    public void KickEntryPoint()
    {
        catContext.KickCaller();
        UpdateDisplay();
    }

    public void PlayEntryPoint()
    {
        catContext.PlayCaller();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        flavorText.text = catContext._flavorText;
        statusText.text = catContext._statusText;
        animator.Play(catContext._animator);
    }
}
