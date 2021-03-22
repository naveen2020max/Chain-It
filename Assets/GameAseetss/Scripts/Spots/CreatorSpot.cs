using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naveen;

public class CreatorSpot : SpotBase
{
    public UnitBase unit;
    // Start is called before the first frame update
    void Start()
    {
        ChangeDirection();
        curmoveTime = MoveTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.isStarted)
        {
            PlayerInAction(); 
        }
    }

    public override void SpotAction()
    {
        UnitBase u = PoolManager.instance.objectPooler.SpawnFromPool("Units", transform.position + MoveDir, Quaternion.identity);
        u.direction = direction;
        u.ChangeDirection();
    }

    
}
