﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxMagicaEffect : Effect
{
    private float modAmount;
    public override void DoModify()
    {
        creatureModifyable.MaxMpEffectMod += (int)modAmount;
    }

    public override void UndoModify()
    {
        creatureModifyable.MaxMpEffectMod -= (int)modAmount;
    }
}
