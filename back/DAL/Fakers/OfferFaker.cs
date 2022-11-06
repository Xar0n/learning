using Bogus;
using Core.Enums;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fakers
{
    public class OfferFaker : Faker<Offer>
    {
        public OfferFaker()
        {
            int offerId = 4;
            RuleFor(o => o.Id, f => offerId++);
            RuleFor(o => o.Name, f => f.Lorem.Sentence(5, 5));
            RuleFor(o => o.Description, f => f.Lorem.Sentence(5, 5));
            RuleFor(o => o.State, f => State.Created);
        }
    }
}
