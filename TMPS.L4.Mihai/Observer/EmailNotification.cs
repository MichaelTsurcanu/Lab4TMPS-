using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Observer
{
    class EmailNotification : IObserver
    {
        public void Update(double balance)
        {
            Console.WriteLine($"Email Notification: Your balance is {balance}");
        }
    }
}
