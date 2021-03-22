using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushUnit : UnitBase
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Action(UnitBase _base)
    {
        if (_base.SelfFunction)
        {
            _base.Action(this);
            return;
        }
        if (CanMove(_base))
        {
            //Debug.Log("enter");
            transform.position += MoveDir; 
            _base.transform.position += MoveDir;
            _base.curmoveTime = 0;
        }
    }

    private bool CanMove(UnitBase u)
    {
        //Debug.Log(u);
        if (u.Movable)
        {
            return u.CheckNextBox(out UnitBase _ub,MoveDir) ? CanMove(_ub) : true;
        }
        return false;
    }
}
