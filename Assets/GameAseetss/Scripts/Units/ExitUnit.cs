using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitUnit : UnitBase
{
    public override void Action(UnitBase _base)
    {
        if (_base.WinUnit)
        {
            Debug.Log("End");
            GameManager.instance.LevelCompleted(); 
        }
    }
}
