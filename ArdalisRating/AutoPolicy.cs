using System;

namespace ArdalisRating
{
    public class AutoPolicy
    {
        public decimal CalculateRating(Policy policy)
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
    }
}
