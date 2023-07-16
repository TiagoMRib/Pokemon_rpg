using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move 
{
    // didnt really get this part
    public MoveBase moveBase{get; set;}
    public int PP{get; set;}

    public Move(MoveBase mBase)
    {
        moveBase = mBase;
        PP = mBase.PP;
    }
}
