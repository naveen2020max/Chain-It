using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUnit : UnitBase
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
        }
    }
}
