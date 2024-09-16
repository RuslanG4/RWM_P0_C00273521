using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PrimesTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void PrimesTestSimplePasses()
    {
        int[] input = { 1, 2, 3, 4, 5,6,7,8,9,10,11 };
        int[] output = Primes.primes(input);
        int[] expected = { 2,3,5,7,11};

        CollectionAssert.AreEqual(expected, output);
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PrimesTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
