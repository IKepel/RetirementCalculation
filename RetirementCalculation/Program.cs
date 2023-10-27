namespace RetirementCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Kostya", 60, 40);

            var usaPension = person.GetRetirementValue(CalculatePensionUSA);
            var japanPension = person.GetRetirementValue(CalculatePensionJapan);
            var germanyPension = person.GetRetirementValue(CalculatePensionGermany);

            Console.WriteLine($"{person.Name} receives a pension in the United States in the amount of {usaPension}");
            Console.WriteLine($"{person.Name} receives a pension in Japan in the amount of {japanPension}");
            Console.WriteLine($"{person.Name} receives a pension in Germany in the amount of {germanyPension}");
        }

        static double CalculatePensionUSA(int age, int yearsOfExperience)
        {
            double pension = (age * 1000) + (yearsOfExperience * 500);
            return pension;
        }

        static double CalculatePensionJapan(int age, int yearsOfExperience)
        {
            double pension = (age * 1200) + (yearsOfExperience * 600);
            return pension;
        }

        static double CalculatePensionGermany(int age, int yearsOfExperience)
        {
            double pension = (age * 800) + (yearsOfExperience * 400);
            return pension;
        }
    }
}