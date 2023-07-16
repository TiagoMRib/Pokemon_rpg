using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    PokemonBase pkBase;
    int level;

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        pkBase = pBase;
        level = pLevel;

    }


    public int Attack {
        get { return Mathf.FloorToInt((pkBase.Attack * level) / 100f) + 5;}
    }

    public int Defense {
        get { return Mathf.FloorToInt((pkBase.Defense * level) / 100f) + 5;}
    }

    public int SpecialAttack {
        get { return Mathf.FloorToInt((pkBase.SpecialAttack * level) / 100f) + 5;}
    }

    public int SpecialDefense {
        get { return Mathf.FloorToInt((pkBase.SpecialDefense * level) / 100f) + 5;}
    }

    public int Speed {
        get { return Mathf.FloorToInt((pkBase.Speed* level) / 100f) + 5;}
    }

    public int MaxHP {
        get { return Mathf.FloorToInt((pkBase.MaxHP * level) / 100f) + 10;}
    }

    
}
