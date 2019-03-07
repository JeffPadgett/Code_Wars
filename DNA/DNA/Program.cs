using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{

     /*Deoxyribonucleic acid(DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

     If you want to know more http://en.wikipedia.org/wiki/DNA


      In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have function with one side of the DNA(string, except for Haskell); you need to get the other complementary side.DNA strand is never empty or there is no DNA at all (again, except for Haskell).*/

    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string MakeComplement(string dna)
        {
            char[] conversionString = dna.ToCharArray();

            for(int i = 0; i < conversionString.Length; i++)
                switch(conversionString[i])
                {
                    case 'A':
                        conversionString[i] = 'T';
                        break;
                    case 'C':
                        conversionString[i] = 'G';
                        break;
                    case 'T':
                        conversionString[i] = 'A';
                        break;
                    case 'G':
                        conversionString[i] = 'C';
                        break;
                }

            string output = new string(conversionString);
            return output;

            
        }
    }
}
