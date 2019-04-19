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
                    dnaFrequency['A'] += 1;
                    break;
                case 'C':
                    dnaFrequency['C'] += 1;
                    break;
                case 'G':
                    dnaFrequency['G'] += 1;
                    break;
                case 'T':
                    dnaFrequency['T'] += 1;
                    break;
                default:
                    throw new ArgumentException("The DNA not found!");
            }
        }

        return dnaFrequency;
    }
}