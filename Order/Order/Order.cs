using System;
using System.Collections.Generic;

namespace Order
{
    class Order:IComparable
    {
        public Order(long id)
        {
            Id = id;
        }

        public Order() { }

        public long Id { get; }
        public List<OrderItem> OrderItem { get; set; }

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m!=null&&m.Id==Id;
        }

        public override int GetHashCode()
        {
            return (int) (Id*100);
        }

        public int CompareTo(object obj)
        {
            Order order=obj as Order;
            if (order==null)
            {
                throw new ArgumentException();
            }

            return Id.CompareTo(order.Id);
        }
    }
}
