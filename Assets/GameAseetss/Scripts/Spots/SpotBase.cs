using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotBase : MonoBehaviour
{
    public UnitDirection direction;
    public float MoveTime;

    protected bool PlayerIn;
    protected Vector3 MoveDir = Vector3.zero;

    public float curmoveTime { get; set; }

    public void PlayerInAction()
    {


        if (curmoveTime > MoveTime)
        {
            curmoveTime = 0;
            SpotAction();
        }
        else
        {
            curmoveTime += Time.deltaTime;
        }


    }

    public void ChangeDirection()
    {
        switch (direction)
        {
            case UnitDirection.TOP:
                MoveDir = Vector3.forward;
                break;
            case UnitDirection.DOWN:
                MoveDir = Vector3.back;
                break;
            case UnitDirection.RIGHT:
                MoveDir = Vector3.right;
                break;
            case UnitDirection.LEFT:
                MoveDir = Vector3.left;
                break;
            default:
                break;
        }
    }


    public virtual void SpotAction()
    {

    }

}
