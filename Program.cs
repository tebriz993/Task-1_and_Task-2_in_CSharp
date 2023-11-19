using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MasterCard mastercard1 = new MasterCard(1000,1234);
            mastercard1.forMasterCardCheckBalance();

            VisaCard visaCard1 = new VisaCard(1000,1232);
            visaCard1.forVisaCardCheckBalance();

        }

    }

     interface IBankCard 
     {
        void forVisaCardPaying();
        void forVisaCardCheckBalance();


        void forMasterCardPaying();
        void forMasterCardCheckBalance();

     }



    class VisaCard
    {
        public readonly int amount = 1000;
        public int forVisaCardPaying_Amount;
        public int End_Amount;

        public VisaCard(int amount, int forVisaCardPaying_Amount)
        {
            this.amount = amount;
            this.forVisaCardPaying_Amount = forVisaCardPaying_Amount;


        }

        public void forVisaCardPaying()
        {
            Console.WriteLine($"Visacard ucun Odenilen mebleg: {forVisaCardPaying_Amount}");
        }

        public void forVisaCardCheckBalance()
        {
            Console.WriteLine($"Visacard ucun Son mebleg: " + (amount + forVisaCardPaying_Amount));
        }

    }



    class MasterCard
    {
        public readonly int amount = 1000;
        public int forMasterCardPaying_Amount;
        public int End_Amount;

        public MasterCard(int amount, int forMasterCardPaying_Amount)
        {
            this.amount = amount;
            this.forMasterCardPaying_Amount = forMasterCardPaying_Amount;


        }

        public void forMasterCardPaying()
        {
            Console.WriteLine($"Mastercard ucun Odenilen mebleg: {forMasterCardPaying_Amount}");
        }

        public void forMasterCardCheckBalance()
        {
            Console.WriteLine($"Mastercard ucun Son mebleg: " + (amount + forMasterCardPaying_Amount));
        }

    }







}
