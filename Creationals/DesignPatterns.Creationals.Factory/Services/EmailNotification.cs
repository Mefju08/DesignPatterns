using DesignPatterns.Creationals.Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationals.Factory.Services
{
    internal class EmailNotification : INotification
    {
        public void Send(Guid userId, string message)
        {
            Console.WriteLine($"Sending e-mail to {userId}: {message}");
        }
    }
}
