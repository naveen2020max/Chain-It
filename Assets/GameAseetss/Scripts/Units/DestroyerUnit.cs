﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerUnit : UnitBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Action(UnitBase _base)
    {
        _base.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
