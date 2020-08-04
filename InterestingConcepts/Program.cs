using System;
using System.Runtime.CompilerServices;
using InterestingConcepts.InstantiatingObjectsWithoutContructors;

namespace InterestingConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = RuntimeHelpers.GetUninitializedObject(typeof(TaxCalculation)) as TaxCalculation;
            Console.WriteLine(calculator.CalculateVat(11.99));

            var dog = RuntimeHelpers.GetUninitializedObject(typeof(Dog)) as Dog;
            Console.WriteLine(dog.Bark());
        }
    }
}
