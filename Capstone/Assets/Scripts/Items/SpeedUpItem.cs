﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : Item
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void powerUpAction(){
    	GameObject.Find("Player").GetComponent<PlayerController>().speed += 1;
    }


}