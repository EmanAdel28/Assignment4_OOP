using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Q3
{
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
