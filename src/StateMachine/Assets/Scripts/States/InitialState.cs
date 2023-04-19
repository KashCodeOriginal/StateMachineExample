using UnityEngine;

public class InitialState : IState<Bootstrap>, IEnterable, IExitable, ITickable
{
    public Bootstrap Initializer { get; }

    private float timer = 0;

    public InitialState(Bootstrap initializer)
    {
        Initializer = initializer;
    }

    public void OnEnter()
    {
        Debug.Log("State 2 Entered");
    }

    public void OnExit()
    {
        Debug.Log("State 2 Exited");
    }

    public void Tick()
    {
        Debug.Log("State 2 Tick: " + timer);
        
        timer += Time.deltaTime;

        if (timer >= 0.3f)
        {
            Initializer.StateMachine.SwitchState<LoadingState>();
        }
    }
}