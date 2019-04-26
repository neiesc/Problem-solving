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
            switch (dna) {
                case 'A':
                case 'C':
                case 'G':
                case 'T':
                    dnaFrequency[dna]++;
                    break;
                default:
                    throw new ArgumentException("The DNA not found!");
            }
        }

        return dnaFrequency;
    }
}