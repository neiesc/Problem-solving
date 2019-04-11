using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Not match length the firstStrand and secondStrand");
        }

        var hammingDistance = firstStrand.Zip(secondStrand, (first, second) => first != second)
            .Count(x => x);

        return hammingDistance;
    }
}