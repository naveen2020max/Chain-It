using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinUnit : UnitBase
{
    public override void Action(UnitBase _base)
    {
        //int uD = (int)_base.direction;
        //int temp = RandomInt(uD);
        _base.direction = direction;
        _base.ChangeDirection();
    }

    //private int RandomInt(int _u)
    //{
    //    int r = Random.Range(-2, 3);
    //    if (r == 0)
    //    {
    //        return RandomInt(_u);
    //    }
    //    if(r == _u && r == -_u)
    //    {
    //        return RandomInt(_u);
    //    }
    //    return r;
    //} 
}
