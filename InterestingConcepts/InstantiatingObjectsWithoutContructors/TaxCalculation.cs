using System;

namespace InterestingConcepts.InstantiatingObjectsWithoutContructors
{
    public class TaxCalculation
    {
        public TaxCalculation(string license)
        {
            ValidateLicense(license);
        }

        public double CalculateVat(double price)
        {
            return Math.Round(price * 0.22, 2);
        }

        private void ValidateLicense(string license)
        {
            if (string.IsNullOrEmpty(license))
            {
                throw new ArgumentException("Your license is invalid, idiot", nameof(license));
            }
        }
    }
}
