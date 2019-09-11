using System.Collections.Generic;

public class StateContext
{
    public List<State> StateList = new List<State>();
    public State CurrentState { get; private set; }

    //  public bool SelfTransit = true;

    object Locker = new object();

    public void setCurrentState(State state)
    {
        if (state == null || !StateList.Contains(state))
            return;

        CurrentState = state;
    }

    public void addState(State state)
    {
        if (state == null || StateList.Contains(state))
            return;

        StateList.Add(state);
    }

    public void transitState(State targetState)
    {
        if (targetState == null)
            return;

        lock (Locker)
        {
            CurrentState?.OnExit();
            CurrentState = targetState;
            CurrentState?.OnEnter();
        }
    }

}
