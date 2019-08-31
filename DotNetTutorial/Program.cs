using System;

namespace DotNetTutorial
{
    class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegistedAirMail = 2,
            Express = 3
        }
        static void Main(string[] args)
        {
            var calculate = new Calculation();

            Console.WriteLine(calculate.Add(100, 100));
            Console.WriteLine("Hello World!");

            var names = new string[3]{ "Setefan", "Józek", "Kazik" };
            Console.WriteLine(string.Join(", ", names));

            var method = ShippingMethod.Express;
            Console.WriteLine("Int: " + (int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            Console.WriteLine("methodname - " + (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName));
            Console.WriteLine("methodname int - " + (int)Enum.Parse(typeof(ShippingMethod), methodName));
        }
    }
}
