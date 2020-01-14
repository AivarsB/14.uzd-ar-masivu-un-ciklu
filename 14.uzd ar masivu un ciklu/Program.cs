using System;

namespace _14.uzd_ar_masivu_un_ciklu
{
    class Program
    {
        static void Main(string[] args)
        {
            int water = 3;
            int[] container = new int[] { 1, 2, 4, 6, 8 };

            for (int i = 0; i < container.Length; i++)
            {
                if (container[i] > water)
                {
                    Console.WriteLine($"Tilpumu {water} var ieliet traukaa {container[i]}");
                }
                else
                {
                    Console.WriteLine($"Tilpumu {water} nevar ieliet traukaa {container[i]}");
                }
            }

        }
    }
}

// Mums ir ūdens 3L un 5 trauki atbilstoši ar tilpumu 1,2,4,6,8 L. 
// Mūsu programmai ir jānosaka un jāizvada uz ekrāna, kuros traukos šo ūdeni mēs varam ieliet.