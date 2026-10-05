namespace ConsoleAppDataCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dataCenter = 0.08m;
            decimal consommation;

            Console.WriteLine("Quelle est la consommation de votre date center");
            consommation = Convert.ToDecimal(Console.ReadLine());

            decimal consommationDouble = consommation * 2;

            int annee = 0;

            while (consommation <= consommationDouble)
            {
                consommation = consommation + (consommation * dataCenter);
                annee++;
            }

            Console.WriteLine($"Il faudra {annee} ans pour doubler la consommation.");

        }
    }
}
