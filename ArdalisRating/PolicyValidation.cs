using System;

namespace ArdalisRating
{
    internal class PolicyValidation
    {
        public static decimal PolicyValidation_Auto(Policy policy, decimal Rating)
        {
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                else
                {
                    return 900m;
                }
            }
            return 0;
        }

        public static void PolicyValidation_Land(Policy policy, decimal Rating)
        {
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land Alert 1");
            }
            else if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Land Alert 2");
            }
        }

        public static void PolicyValidation_Life(Policy policy, decimal Rating)
        {
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life Alert 1");
            }
            else if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Life Alert 2");
            }
            else if (policy.Amount == 0)
            {
                Console.WriteLine("Life Alert 3");
            }
        }
    }
}
