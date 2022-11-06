using DAL.StateMachines.Events;
using MassTransit;
namespace DAL.StateMachines
{
    public class OfferStateMachine : MassTransitStateMachine<OfferState>
    {
        // Состояния
        public State Submitted { get; private set; }
        public State Accepted { get; private set; }

        // События    
        public Event<SubmitOffer> SubmitOffer { get; private set; }
        public Event<OfferAccepted> OfferAccepted { get; private set; }

        public OfferStateMachine()
        {
            InstanceState(x => x.CurrentState, Submitted, Accepted);
            
            Event(() => SubmitOffer, x => {
                x.CorrelateById(context => context.Message.OfferId)
                .SelectId(selector => Guid.NewGuid());

                x.InsertOnInitial = true;
                x.SetSagaFactory(context => new OfferState
                {
                    CorrelationId = context.Message.OfferId
                });
            });
            Event(() => OfferAccepted, x => x.CorrelateById(context => context.Message.OfferId));
            
            Initially(
            When(SubmitOffer)
                .Then(x => x.Saga.OfferDate = x.Message.OfferDate)
                .TransitionTo(Submitted),
            When(OfferAccepted)
                .TransitionTo(Accepted));

            During(Submitted,
                When(OfferAccepted)
                    .TransitionTo(Accepted));

            During(Accepted,
                When(SubmitOffer)
                .Then(x => x.Saga.OfferDate = x.Message.OfferDate).Finalize());
        }

        
    }
}
