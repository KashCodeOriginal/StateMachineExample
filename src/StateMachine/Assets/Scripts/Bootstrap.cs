using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public StateMachine<Bootstrap> StateMachine { get; private set; }
    
    private void Start()
    {
        StateMachine = new StateMachine<Bootstrap>(
            new BootstrapState(this),
            new InitialState(this),
            new LoadingState(this));

        StateMachine.SwitchState<BootstrapState>();
    }
}