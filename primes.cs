using System;
using System.Collections.Generic;
using System.Linq;

namespace primes
{
    public class PrimeGenerator
    {
        public void Run()
        {
            var primes = new List<long> {1,2,5};
            var current = 5;
            var validPrimes = new List<char> { '1', '3', '7', '9'};
            while(true)
            {
                current++;
                if(validPrimes.Contains(current.ToString().Last()))
                {
                    var isPrime = true;
                    for(long i = 3; i < current; i+=2)
                    {
                        if(current % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if(isPrime)
                    {
                        primes.Add(current);
                        Console.WriteLine(current);
                    }
                }
            }
        }
    }
}