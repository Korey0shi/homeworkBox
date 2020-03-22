using System;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    class OrderService
    {

        public List<Order> Orders=new List<Order>();

        public void Add(List<OrderItem>orders)
        {
            foreach (var order in Orders)
            {
                foreach (var orderItem in order.OrderItem)
                {
                    foreach (var item in orders)
                    {
                        if (item.Equals(orderItem))
                        {
                            throw new Exception("出现重复id");
                        }
                    }
                }
            }
            Orders.Add(new Order{OrderItem = orders});
        }

        public void Delete(long id)
        {
            var order = from order1 in Orders where order1.Id == id select order1;
            var enumerable = order.ToList();
            if (!enumerable.Any())
            {
                throw new Exception("没有对应id");
            }
            foreach (var order1 in enumerable) Orders.Remove(order1);
        }

        public void Update(long id, string name, string custom)
        {
            bool hasValue=false;
            foreach (var order1 in Orders)
            {
                var order = from orderItem in order1.OrderItem where orderItem.Id == id select orderItem;
                var orderItems = order.ToList();
                if (orderItems.Count!=0)
                {
                    hasValue = true;
                    foreach (var orderItem in order1.OrderItem)
                    {
                        if (orderItem.Id==id)
                        {
                            orderItem.Name = name;
                            orderItem.Custom = custom;
                        }
                    }
                    break;
                }
            }
            if (!hasValue)
            {
                throw new Exception("没有该id");
            }
        }

        public string SelectById(long id)
        {
            string result = "";
            var order = from order1 in Orders where order1.Id == id select order1;
            foreach (var order1 in order) 
            foreach (var orderItem in order1.OrderItem)
                result += orderItem + "\n";
            if (result=="")
            {
                throw new Exception("没有该订单id");
            }
            return result;
        }

        public string SelectByName(string name)
        {
            string result="";
            foreach (var order1 in Orders)
            {
                var order = from orderItem in order1.OrderItem where orderItem.Name == name select orderItem;
                foreach (var orderItem in order) result += orderItem + "\n";
            }
            if (result=="")
            {
                throw new Exception("没有该商品");
            }
            return result;
        }

        public string SelectByCustom(string custom)
        {
            string result="";
            foreach (var order1 in Orders)
            {
                var order = from orderItem in order1.OrderItem where orderItem.Custom == custom select orderItem;
                foreach (var orderItem in order) result += orderItem + "\n";
            }
            if (result=="")
            {
                throw new Exception("没有该买家");
            }
            return result;
        }

        public void Sort()
        {
            Orders.Sort();
        }

    }
}
