﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using EGamePlay.Combat.Ability;
using EGamePlay;

public class Buff1001Entity : AbilityEntity
{
    public override void ActivateAbility()
    {
        base.ActivateAbility();
        EndAbility();
    }

    public override void EndAbility()
    {
        base.EndAbility();
    }
}
