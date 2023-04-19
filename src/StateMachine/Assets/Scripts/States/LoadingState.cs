using UnityEngine;

public class LoadingState : IState<Bootstrap>, IEnterable, IExitable
{
    public Bootstrap Initializer { get; }

    public LoadingState(Bootstrap initializer)
    {
        Initializer = initializer;
    }

    public void OnEnter()
    {
        Debug.Log("State 3 Entered");
    }

    public void OnExit()
    {
        Debug.Log("State 3 Exited");
    }
}