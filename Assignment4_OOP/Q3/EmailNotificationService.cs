﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Q3
{
    public class EmailNotificationService : INotificationService
    {
        
        public void SendNotification(string recipient, string message)
        {
            
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }
}
