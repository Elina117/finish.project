using System;
namespace next
{
	public class BankTransaction
	{
        readonly DateTime data = DateTime.Now;
        private decimal summa;
        public decimal Summa // 13.1 СW
        {
            get { return summa; }
            set { summa = value; }
        }
        public BankTransaction(decimal summa)
        {
            Summa = summa;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Date:{data} Sum:{summa}");
        }
        public override string ToString()
        {
            return $"time: {data} money: {Summa}";
        }
    }
}

