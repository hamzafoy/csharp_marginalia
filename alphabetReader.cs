using System;
using System.Text;
namespace HamzasAlphabetReader
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderAlphabet();
        }
        private static void RenderAlphabet()
        {
            StringBuilder alphabetString = new StringBuilder();
            for (char i = char.MinValue; i < char.MaxValue; i++) {
                if(i >= 'A' && i <= 'Z')
                {
                    alphabetString.Append(i);
                }
                
            }
            Console.WriteLine(alphabetString.ToString());
        }
    }
}