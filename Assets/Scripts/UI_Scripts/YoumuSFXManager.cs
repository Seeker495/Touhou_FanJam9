using System.Collections.Generic;
using CarterGames.Assets.AudioManager;
using UnityEngine;

public class YoumuSFXManager: MonoBehaviour
{
    [SerializeField] string attackSFX_1, attackSFX_2;

    public void YoumuSFX(string SFXname)
    {
        var randVolume = Random.Range(0.2f, 1f);
        AudioManager.instance.Play(SFXname, randVolume);
    }

    public void YoumuAttackSFX()
    {
        //randomize swoosh
        var SFXnames = new List<string> { attackSFX_1, attackSFX_2 };
        int index = Random.Range(0, SFXnames.Count);
        var attackSFX = SFXnames[index];

        AudioManager.instance.Play(attackSFX);
    }
}
