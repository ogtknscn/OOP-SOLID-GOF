using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Coupling
{
    internal class Order
    {
        private readonly INotification notificationService;
        public Order(INotification notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            notificationService.SendNotification("Order placed successfully");
        }
    }
}
