﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StateMachines.Events
{
    public interface OfferAccepted
    {
        Guid OfferId { get; }
    }
}
