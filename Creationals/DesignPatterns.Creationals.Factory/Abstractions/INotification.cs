using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationals.Factory.Abstractions
{
    internal interface INotification
    {
        public void Send(Guid userId, string message);
    }
}
