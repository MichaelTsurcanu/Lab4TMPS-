using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Iterator
{
    class TransactionHistoryIterator : IIterator
    {
        private List<string> transactions;
        private int position;

        public TransactionHistoryIterator(List<string> transactions)
        {
            this.transactions = transactions;
            position = 0;
        }

        public bool HasNext()
        {
            return position < transactions.Count;
        }

        public object Next()
        {
            string transaction = transactions[position];
            position++;
            return transaction;
        }
    }
}
