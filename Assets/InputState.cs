using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputState : State
{
    public Action InputEvent;

    public InputState(StateContext context) : base(context)
    {
        Context.addState(this);
    }
}
