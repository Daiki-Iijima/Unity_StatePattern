using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputContext : StateContext
{
    public void onInput()
    {
        (CurrentState as InputState).InputEvent();
    }
}
