﻿using System;
using UnityEngine;
    private int money;

    */

    public TurretBluePrint GetTurretToBuild()
    {
        return turretToBuild;
    }

    public GameObject anotherTurretPrefab;
       
        money = turretToBuild.money;
        if (turretToBuild.money != 0)
        {
            InvokeRepeating("AddMoney", 2f, 2f);
        }
    void AddMoney()
    {
        PlayerStats.Money += money;
    }