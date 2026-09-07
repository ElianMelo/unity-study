using UnityEngine;

namespace UnityStudy.DesignPatterns.State
{
    public class IdleState : IState
    {
        private ParticleSystem particle;

        public IdleState(ParticleSystem particle)
        {
            this.particle = particle;
        }

        public void Enter()
        {
            // code that runs when we first enter the state
        }

        public void Execute()
        {
            // Here we add logic to detect if the conditions exist to
            // transition to another state
        }

        public void Exit()
        {
            // code that runs when we exit the state
        }
    }
}
