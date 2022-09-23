using System;

namespace ObjectOrientedPractics.Services
{
    public static class ValueValidator
    {
        public static void AssertValueInRange(string nameProperty, double value, double MinValueCost, double MaxValueCost)
        {
            if (value < MinValueCost || value > MaxValueCost)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {MinValueCost} and {MaxValueCost} (inclusive).");
            }
        }

        public static void AssertStringOnLength(string propertyName, string value, int maxLength)
        {
            if (value.Length > maxLength)
                throw new ArgumentException(
                    $"number of characters in the field {propertyName} must be less than {maxLength}.");
        }
    }
}