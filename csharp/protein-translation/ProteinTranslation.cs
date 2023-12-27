using System;
using System.Linq;
using System.Collections.Generic;


public static class ProteinTranslation
{
    private static string GetTranslation(string codon)
    {
        if (codon == "AUG")
        {
            return "Methionine";
        }
        else if (codon == "UUU" || codon == "UUC")
        {
            return "Phenylalanine";
        }
        else if (codon == "UUA" || codon == "UUG")
        {
            return "Leucine";
        }
        else if (codon == "UCU" || codon == "UCC" || codon == "UCA" || codon == "UCG")
        {
            return "Serine";
        }
        else if (codon == "UAU" || codon == "UAC")
        {
            return "Tyrosine";
        }
        else if (codon == "UGU" || codon == "UGC")
        {
            return "Cysteine";
        }
        else if (codon == "UGG")
        {
            return "Tryptophan";
        }
        else if (codon == "UAA" || codon == "UAG" || codon == "UGA")
        {
            return null;
        }
        else
        {
            return null;
        }
    }
    public static string[] Proteins(string strand)
    {
        List<string> proteins = new List<string>();

        for (int i = 0; i < strand.Length; i += 3)
        {
            string codon = GetTranslation(strand.Substring(i, 3));
            if (codon != null)
            {
                proteins.Add(codon);
            }
            else
            {
                break;
            }
        }

        return proteins.ToArray();

    }
}