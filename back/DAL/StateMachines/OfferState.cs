using MassTransit;
using System;

namespace DAL.StateMachines
{
    public class OfferState : SagaStateMachineInstance
    {
        public Guid CorrelationId { get; set; }
        public int CurrentState { get; set; }
        public DateTime OfferDate { get; set; }
    }
}
