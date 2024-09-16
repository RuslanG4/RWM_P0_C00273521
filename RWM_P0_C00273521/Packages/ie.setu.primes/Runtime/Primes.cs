using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primes
{
   public static int[] primes(int[] _ints)
    {
        List<int> tempArray = new List<int>();
        foreach(int number in _ints){
            int tempDivisible = number;
            int primeField = 0;
            while(tempDivisible > 1)
            {
                if(number % tempDivisible == 0)
                {
                    primeField++;
                }
                tempDivisible--;
            }
            if(primeField == 1)
            {
                tempArray.Add(number);
            }
        }
        return tempArray.ToArray(); 
    }
}
