using System;

namespace ArdalisRating
{
    public class RatingEngine
    {
        public decimal Rating { get; set; }

        public void Rate()
        {
            var policyLoader = new PolicyLoader();
            var policyJson = policyLoader.LoadPolicyFromJsonFile("policy.json");

            var policyDeserializer = new PolicyDeserializer();
            var policy = policyDeserializer.DeserializePolicy(policyJson);

            switch (policy.Type)
            {
                case PolicyType.Auto:
                    Rating = new AutoPolicy().CalculateRating(policy);
                    break;
                case PolicyType.Land:
                    Rating = new LandPolicy().CalculateRating(policy);
                    break;
                case PolicyType.Life:
                    Rating = new LifePolicy().CalculateRating(policy);
                    break;
                case PolicyType.Flood:
                    Rating = new Flood().CalculateRating(policy);
                    break;
                default:
                    Console.WriteLine("Default Switch");
                    break;
            }
        }
    }
}
