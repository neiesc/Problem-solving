using System;
using System.Collections.Generic;

public static class NucleotideCount {
    public static IDictionary<char, int> Count (string sequence) {
        var dnaFrequency = new Dictionary<char, int> {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };
        
        foreach (var dna in sequence) {
            if (dnaFrequency.ContainsKey(dna))
            {
                dnaFrequency[dna]++;
            }
            else
            {
                throw new ArgumentException("The DNA not found!");
            }
        }
        
        return dnaFrequency;
    }
}