using System;

namespace ArdalisRating
{
    public class LifePolicy
    {
        public decimal CalculateRating(Policy policy)
        {
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life Alert 1");
                return 0;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Life Alert 2");
                return 0;
            }
            if (policy.Amount == 0)
            {
                Console.WriteLine("Life Alert 3");
                return 0;
            }

            decimal rating = CalculateLifeRating(policy);
            return rating;
        }

        private decimal CalculateLifeRating(Policy policy)
        {
            decimal rating = 0;
            // Implementa la lógica de cálculo real para el seguro de vida aquí.
            return rating;
        }
    }
}
