using System;
using System.Collections.Generic;

namespace primes
{
    public class PrimeGenerator
    {
        public void Run()
        {
            var primes = new List<int>();
            var current = 0;
            while(true)
            {
                current++;
                var isPrime = true;
                for(var i = 2; i < current; i++)
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