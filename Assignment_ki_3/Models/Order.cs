using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_ki_3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public enum OrderStatus
        {
            Pending = 0 , Done = 1 , Cancel = -1
        }
        public Order()
        {
            CreatedAt = DateTime.Now;
            Status = (int)OrderStatus.Pending;
        }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}