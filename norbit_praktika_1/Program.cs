using System.Text;

namespace norbit_praktika_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string result = PercentCalculation(1000, 3, 10);
            Console.WriteLine(result);
        }

        static string PercentCalculation(double initial_deposit, int years, int interest_rate)
        {
            StringBuilder result = new StringBuilder();
            double currentAmount = initial_deposit;

            for (int i = 1; i <= years; i++)
            {
                double percents = currentAmount * interest_rate / 100;
                currentAmount += percents;
                result.AppendLine($"Год {i}: {currentAmount:F2} руб.");
            }

            return result.ToString();
        }
    }
}
