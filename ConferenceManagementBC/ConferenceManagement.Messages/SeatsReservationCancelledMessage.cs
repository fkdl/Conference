﻿using System;
using ENode.Infrastructure;

namespace ConferenceManagement.Messages
{
    [Serializable]
    [Code(1602)]
    public class SeatsReservationCancelledMessage : ApplicationMessage
    {
        public Guid ConferenceId { get; set; }
        public Guid ReservationId { get; set; }
    }
}