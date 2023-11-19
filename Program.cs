using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
VisaCard visacard1=new VisaCard(0,250,)
        }

    }

        class interface IBankCard:VisaCard,MasterCard
        {
        public forVisaCardPaying();

        public forVisaCardCheckBalance();

        }



        class interface VisaCard
        {
        public int amount=0;
        public int Paying_Amount;
        public int End_Amount;

        public VisaCard(int amount, int Paying_Amount)
        {
            this.amount = amount;
            this.Paying_Amount=Paying_Amount;
            this.End_Amount = End_Amount;

        }

        public void forVisaCardPaying()
        {
            Console.WriteLine($"Visacard ucun Odenilen mebleg: {Paying_Amount}");
        }

        public void forVisaCardCheckBalance()
        {
            Console.WriteLine($"Visacard ucun Son mebleg: {End_Amount}");
        }

        }



        class interface MasterCard
        {

        public int amount=0;
        public int Paying_Amount;
        public int End_Amount;

        public MasterCard(int amount, int Paying_Amount, int End_Amount)
        {
            this.amount = amount;
            this.Paying_Amount = Paying_Amount;
            this.End_Amount = End_Amount;

        }

        public void forMasterCardPaying()
        {
            Console.WriteLine($"Mastercard ucun Odenilen mebleg: {Paying_Amount}");
        }

        public void forMasterCardCheckBalance()
        {
            Console.WriteLine($"Mastercard ucun Son mebleg: {End_Amount}");
        }

        }
    

   
}
