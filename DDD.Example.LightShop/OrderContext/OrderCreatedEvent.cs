using System;
using System.Collections.Generic;
using IdGen;

namespace DDD.Example.LightShop.OrderContext
{
    public class OrderCreatedEvent
    {
        public static OrderCreatedEvent NewOrderCreatedEvent(Guid id, List<Product> orderItems, ShippingInfo shippingInfo)
        {
            return new OrderCreatedEvent(id, orderItems, shippingInfo);
        }

        public Guid EventId { get; }

        public Guid AggregateRootId { get; }
        
        public DateTime OccuredOn { get; }
        
        public List<Product> OrderItems { get; }
        
        public ShippingInfo ShippingInfo { get; }


        private OrderCreatedEvent(Guid id, List<Product> orderItems, ShippingInfo shippingInfo)
        {
            EventId = Guid.NewGuid();
            AggregateRootId = id;
            OrderItems = orderItems;
            ShippingInfo = shippingInfo;
            OccuredOn = DateTime.Now;
        }
    }
}