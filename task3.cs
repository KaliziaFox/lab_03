using CurrencyConversion;

namespace CurrencyConversion
{
    class Currency
    {
        public Currency(double value)
        {
            Value = value;
        }
        public double Value { get; set; }
    }

    class CurrencyUSD : Currency
    {
        private static double usdToEurRate;
        private static double usdToRubRate;

        public CurrencyUSD(double value) : base(value) { }

        public static implicit operator CurrencyUSD(int v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator CurrencyEUR(CurrencyUSD usd)
        {
            double eurValue = usd.Value * usdToEurRate;
            return new CurrencyEUR(eurValue);
        }

        public static explicit operator CurrencyRUB(CurrencyUSD usd)
        {

            double rubValue = usd.Value * usdToRubRate;
            return new CurrencyRUB(rubValue);
        }
    }

    class CurrencyEUR : Currency
    {
        private static double eurToRubRate;

        public CurrencyEUR(double value) : base(value) { }

        public static explicit operator CurrencyRUB(CurrencyEUR eur)
        {
            double rubValue = eur.Value * eurToRubRate;
            return new CurrencyRUB(rubValue);
        }
    }

    class CurrencyRUB : Currency
    {
        private static double usdToRubRate;
        private static double eurToRubRate;

        public CurrencyRUB(double value) : base(value) { }

        public static explicit operator CurrencyUSD(CurrencyRUB rub)
        {
            double usdValue = rub.Value / usdToRubRate;
            return new CurrencyUSD(usdValue);
        }

        public static explicit operator CurrencyEUR(CurrencyRUB rub)
        {
            double eurValue = rub.Value / eurToRubRate;
            return new CurrencyEUR(eurValue);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        double usdToRubRate = 99.27;
        double eurToRubRate = 105.95;
        double usdToEurRate = 0.944;

        CurrencyUSD usd = 100; 
        CurrencyEUR eur = (CurrencyEUR)usd; 
        CurrencyRUB rub = (CurrencyRUB)eur;

        Console.WriteLine("100 USD в EUR: " + eur.Value);
        Console.WriteLine("100 USD в RUB: " + rub.Value);
        Console.WriteLine("100 EUR в RUB: " + ((CurrencyRUB)eur).Value);

        Console.WriteLine("Укажите новый курс обмена USD в RUB:");
        usdToRubRate = Convert.ToDouble(Console.ReadLine());

        CurrencyRUB newRub = (CurrencyRUB)usd;

        Console.WriteLine("100 USD в новых RUB: " + newRub.Value);
    }
}