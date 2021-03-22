using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitDirection { TOP= -2, DOWN = 2, RIGHT = 1, LEFT = -1}

public class UnitBase : MonoBehaviour,Naveen.IInfo
{
    public UnitDirection direction;
    public float MoveTime;
    public LayerMask mask;
    public bool Movable;
    public bool SelfFunction;
    public bool WinUnit;

    //for movement
    protected Vector3 MoveDir = Vector3.zero;

    public float curmoveTime { get; set; }


    public void Move()
    {
        if (!GameManager.instance.isStarted)
            return;
        
        if (curmoveTime > MoveTime)
        {
            curmoveTime = 0;
            if (!CheckNextBox())
                transform.position += MoveDir;
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

    public bool CheckNextBox()
    {
        if(Physics.Raycast(transform.position,MoveDir,out RaycastHit hit, 1,mask))
        {
            //hit.collider.GetComponent<UnitBase>().Action(this);
            Action(hit.collider.GetComponent<UnitBase>());
            return true;
        }
        return false;
    }
    public bool CheckNextBox(out UnitBase ub,Vector3 _moveDir)
    {
        if (Physics.Raycast(transform.position, _moveDir, out RaycastHit hit, 1, mask))
        {
            //hit.collider.GetComponent<UnitBase>().Action(this);
            //Action(hit.collider.GetComponent<UnitBase>());
            ub = hit.collider.GetComponent<UnitBase>();
            return true;
        }
        ub = null;
        return false;
    }

    public virtual void Action(UnitBase _base)
    {
        Debug.Log("No Action");
    }

    public void FillInfo(object _info)
    {
        
    }
}
