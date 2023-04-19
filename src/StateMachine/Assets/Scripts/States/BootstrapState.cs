using UnityEngine;

public class BootstrapState : IState<Bootstrap>, IEnterable, IExitable
{
    public Bootstrap Initializer { get; }

    public BootstrapState(Bootstrap initializer)
    {
        Initializer = initializer;
    }

    public void OnEnter()
    {
        Debug.Log("State 1 Entered");
        
        Initializer.StateMachine.SwitchState<InitialState>();
    }

    public void OnExit()
    {
        Debug.Log("State 1 Exited");
    }
}