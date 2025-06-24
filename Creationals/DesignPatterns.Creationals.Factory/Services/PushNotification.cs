using DesignPatterns.Creationals.Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationals.Factory.Services
{
    internal class PushNotification : INotification
    {
        public void Send(Guid userId, string message)
        {
            Console.WriteLine($"Sending push to {userId}: {message}");
        }
    }
}
