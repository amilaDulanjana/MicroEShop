﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.Events
{
    public class OrderStatusChangedToStockConfirmedDomainEvent : INotification
    {
        public int OrderId { get; }

        public OrderStatusChangedToStockConfirmedDomainEvent(int orderId)
            => OrderId = orderId;
    }
}
