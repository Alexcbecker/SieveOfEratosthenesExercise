using System;
using System.Collections.Generic;

namespace sieve_of_eratosthenes_alexander
{
    class SieveOfEratosthenesExercise
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            Console.WriteLine("Welcome! Input a number(N) and the program is going to tell you all the prime numbers between 1 and N!");
            Console.WriteLine("");
            Console.WriteLine("Enter the number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= userInput; i++)
            {
                primeNumbers.Add(i);
            }
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                for (int j = 1; j < primeNumbers.Count; j++)
                {
                    if (primeNumbers[i] != primeNumbers[j] && (primeNumbers[j] % primeNumbers[i] == 0))
                        primeNumbers.RemoveAt(j);
                }
            }
            foreach (int i in primeNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}