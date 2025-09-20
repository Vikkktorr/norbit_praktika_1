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
            if (initial_deposit < 0)
            {
                return "Ошибка: Начальный депозит не может быть отрицательным";
            }

            if (years < 0)
            {
                return "Ошибка: Количество лет не может быть отрицательным";
            }

            if (interest_rate < 0)
            {
                return "Ошибка: Процентная ставка не может быть отрицательной";
            }


            if (initial_deposit == 0)
            {
                return "Ошибка: Начальный депозит не может быть нулевым";
            }

            if (years == 0)
            {
                return "Ошибка: Количество лет не может быть нулевым";
            }

            if (interest_rate == 0)
            {
                return "Ошибка: Процентная ставка равна 0%, сумма не изменится";
            }
            else
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
}