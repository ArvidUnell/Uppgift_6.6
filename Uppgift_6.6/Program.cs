using System;
namespace Uppgift_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            VarannanLiten("Detta är ett exempel. Texten ändras när den skrivs ut.");
        }
        static void VarannanLiten(string meddelande)
        {
            string[] meddelandeArr = meddelande.Split(' ');

            for (int i = 0;i < meddelandeArr.Length;i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(meddelandeArr[i].ToUpper());
                }
                else
                {
                    Console.Write(meddelandeArr[i].ToLower());
                }
                Console.Write(' ');
            }
        }
    }
}