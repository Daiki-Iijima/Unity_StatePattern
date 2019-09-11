using System;

/// <summary>
/// Stateのベースクラス
/// 継承して使う
/// </summary>
public class State
{
    public StateContext Context { get; private set; }

    public Action OnEnter;
    public Action OnExit;

    public State(StateContext context)
    {
        Context = context;
    }
}
