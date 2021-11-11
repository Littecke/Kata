using System;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            VariousDates newDates = new VariousDates(100);

            Console.WriteLine($"\nUnsorted date list: \n{newDates}");
            Console.WriteLine();

            newDates.Sort();
            Console.WriteLine($"\nSorted list: \n{newDates}");
            Console.WriteLine();

            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine($"There is {newDates.Count(month)} of month {month}");
            }
        }
    }
}
// Uppgifter:
// 1.Deklarara ett Interface IVariousDates som definierar
// 	- Metod, Count, som räknar antalet skapade datum i en viss månad
//	- Metod, Count, som returnerar totala antalet datum skapade
//	- Metod, Sort, som sorterar datum en lista

// 2. Implementera IVariousDates i en class, VariousDates
// 3.Här ska ni kunna kompilera (inte köra) programmet utan röda wigglar

// 4. I VariousDates 
//	- Skapa en lista av DateTime
//	- Skapa en constructor som skapar ett antal element i listan med random datum
//	- Override ToString() för att skriva Datum 5 per rad
// 5. I Program skapa en instans av VariousDates och skriv ut den
// 6. Implementera Count och Sort
// 7. Skriv några kodrader i Program som testar Count och Sort