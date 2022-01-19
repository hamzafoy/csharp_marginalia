using System;

namespace HamzasPieShop
{
    class Program
    {
        private static void CalculateWage(int baseWage, WritingCompanyPositions position, TypesOfBooks book)
        {
            int calculatedWage = 0;
            if (position == WritingCompanyPositions.Editor)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage = baseWage * 1;
            }

            if(book == TypesOfBooks.Encyclopedia)
            {
                calculatedWage += 500;
            }

            Console.WriteLine($"The calculated wage is {calculatedWage}");
        }
        static void Main(string[] args)
        {
            UsingEnumerations();
        }

        private static void UsingEnumerations()
        {
            WritingCompanyPositions position = WritingCompanyPositions.Writer;
            TypesOfBooks book = TypesOfBooks.Manuscript;
            int baseWage = 1000;

            CalculateWage(baseWage, position, book);
        }
    }
    enum WritingCompanyPositions
    {
        Writer,//0
        Editor,//1
        Illustrator,//2
        BookBinder//3
    }
    enum TypesOfBooks
    {
        Novella = 5,
        Fanfiction = 10,
        Essay = 15,
        Manuscript = 20,
        Encyclopedia = 25
    }
}