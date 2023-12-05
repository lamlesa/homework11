using System;

namespace homework11
{
    internal class BankTransaction
    {
        private ulong number_giver;
        private ulong number_taker;
        private double sum;
        private DateTime time;
        public ulong Giver {  get { return number_giver; } }
        public ulong Taker {  get { return number_taker; } }
        public double Sum { get { return sum; } }
        public DateTime Time { get { return time; } }
        internal BankTransaction(ulong giver, ulong taker, double sum)
        {
            number_giver = giver;
            number_taker = taker;
            this.sum = sum;
            time = DateTime.Now;
        }
    }
}