using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
            int[] modifiedArray = new int[myArray.Length];
            int greaterNumber = 0;

            //Vytvoř pole typu int s těmito hodnotami { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2}.
            //Pro kontrolu si obsah pole vypiš.
            Console.WriteLine("Puvodni rada cisel: ");
            for (int i = 0;i < myArray.Length; i++)
                
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();

            //Vyhledej záporná čísla a změň je na kladné číslo,
            //zároveň vyhledej nuly a ke každé přičti hodnotu jejího indexu.
            //Výsledné pole si vypiš.
            Console.WriteLine("Rada po modifikaci: ");
            for(int i = 0;i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                   modifiedArray[i] = Math.Abs(myArray[i]);
                }
                else if (myArray[i] == 0)
                {
                    modifiedArray[i] = myArray[i]+i;
                }
                else
                {
                    modifiedArray[i] = myArray[i];
                }
                Console.Write(modifiedArray[i] + ", ");

                //Vyhledej největší číslo v poli a vypiš ho - ze zadani neni jasne
                //jestli puvodni pole nebo to co jsme obdrzeli v ukolu 2.
                //Delam to podle sveho uvazeni s modifikovanym polem.
                if (modifiedArray[i] > greaterNumber)
                {
                    greaterNumber = modifiedArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Nejvetsi cislo v rade je: {greaterNumber}"); //vypsani nejvetsiho csla v modfovanem poli

            //Seřaď prvky v poli od nejmenšího po největší. Znovu z taky -ze zadani neni jasne
            //jestli puvodni pole nebo to co jsme obdrzeli v ukolu 2.
            //Delam to podle sveho uvazeni s modifikovanym polem.

            int temp = 0;
            for(int i = 0;i < modifiedArray.Length; i++)
            {
                for(int j = i + 1; j < modifiedArray.Length; j++)
                {
                    if (modifiedArray[i] > modifiedArray[j]) 
                    {
                        temp= modifiedArray[i];
                        modifiedArray[i]= modifiedArray[j];
                        modifiedArray[j]= temp;
                    }
                }
            }
           
            //Vypsani vysledneho serazeneho pole
            Console.WriteLine("Rada serazena od nejmensiho po nejvetsi: ");
            for (int i = 0; i < modifiedArray.Length; i++)

            {
                Console.Write(modifiedArray[i] + ", ");
            }

            Console.ReadLine();

        }
    }
}