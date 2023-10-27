using static RetirementCalculation.Person;

namespace RetirementCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Kostya", 60, 40);

            PrintFunc usaCalculator = CalculatePensionUSA;
            PrintFunc japanCalculator = CalculatePensionJapan;
            PrintFunc germanyCalculator = CalculatePensionGermany;

            var usaPension = person.GetRetirementValue(usaCalculator);
            var japanPension = person.GetRetirementValue(japanCalculator);
            var germanyPension = person.GetRetirementValue(germanyCalculator);

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