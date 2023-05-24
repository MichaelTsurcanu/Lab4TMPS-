using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Observer
{
    class SmsNotification : IObserver
    {
        public void Update(double balance)
        {
            Console.WriteLine($"SMS Notification: Your balance is {balance}");
        }
    }
}
