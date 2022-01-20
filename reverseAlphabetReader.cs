using system;
using system.text;
namespace hamzasalphabetreader
{
    class program
    {
        static void main(string[] args)
        {
            renderalphabet();
        }
        private static void renderalphabet()
        {
            stringbuilder alphabetstring = new stringbuilder();
            for (char i = char.maxvalue; i > char.minvalue; i--)
            {
                if (i >= 'a' && i <= 'z')
                {
                    alphabetstring.append(i);
                }

            }
            console.writeline(alphabetstring.tostring());
        }
    }
}