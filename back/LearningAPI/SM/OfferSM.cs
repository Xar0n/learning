using Core.Enums;
using DAL.Models;
using Stateless;

namespace LearningAPI.SM
{
    public class OfferSM
    {
        private StateMachine<State, Trigger> _stateMachine;

        public State State => _stateMachine.State;

        public OfferSM(Offer offer)
        {
            _stateMachine = new StateMachine<State, Trigger>(
                () => offer.State, 
                s => offer.State = s
             );
            ConfigureStateMachine();
        }

        public void Submit()
        {
            _stateMachine.Fire(Trigger.Submit);
        }

        public void Send()
        {
            _stateMachine.Fire(Trigger.Send);
        }

        public void Reject()
        {
            _stateMachine.Fire(Trigger.Reject);
        }

        private void ConfigureStateMachine()
        {
            _stateMachine.Configure(State.Created)
                        .Permit(Trigger.Submit, State.Submitted)
                        .Permit(Trigger.Reject, State.Canceled);
            _stateMachine.Configure(State.Submitted)
                .Permit(Trigger.Send, State.Sent)
                .Permit(Trigger.Reject, State.Canceled);
        }
    }
}
