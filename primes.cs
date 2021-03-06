using System;
using System.Collections.Generic;
using System.Linq;

namespace primes
{
    public class PrimeGenerator
    {
        private List<char> validPrimes = new List<char> { '1', '3', '7', '9'};

        public void Run()
        {            
            var primes = new HashSet<long>{2,3,5};
            for(long i = 7; i <= long.MaxValue; i+=2)
            {
                if(validPrimes.Contains(i.ToString().Last()))
                {
                    var validCheck = true;
                    var half = i / 2;
                    foreach(var prime in primes)
                    {
                        if(prime > half)
                        {
                            break;
                        }
                        if(i % prime == 0)
                        {
                            validCheck = false;
                            break;
                        }
                    }
                    if(validCheck)
                    {
                        primes.Add(i);
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}