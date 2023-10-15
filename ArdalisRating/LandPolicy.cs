using System;

namespace ArdalisRating
{
    public class LandPolicy
    {
        public decimal CalculateRating(Policy policy)
        {
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land Alert 1");
                return 0;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Land Alert 2");
                return 0;
            }

            decimal rating = CalculateLandRating(policy);
            return rating;
        }

        private decimal CalculateLandRating(Policy policy)
        {
            decimal rating = 0;
            // Implementa la lógica de cálculo real para el seguro de tierra aquí.
            return rating;
        }
    }
}
