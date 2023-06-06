using System;

namespace _411_Demo_2
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int CheckNum { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public bool IsBrokenOut { get; set; }
    }
}