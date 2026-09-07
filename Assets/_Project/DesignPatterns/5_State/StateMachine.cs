using System;

namespace UnityStudy.DesignPatterns.State
{
    [Serializable]
    public class StateMachine
    {
        public IState CurrentState { get; private set; }

        public IdleState walkState;
        public IdleState jumpState;
        public IdleState idleState;

        public void Initialize(IState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void TransitionTo(IState nextState)
        {
            CurrentState.Exit();
            CurrentState = nextState;
            nextState.Enter();
        }

        public void Execute()
        {
            if(CurrentState != null)
            {
                CurrentState.Execute();
            }
        }
    }
}
