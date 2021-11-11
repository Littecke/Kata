using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class VariousDates : IVariousDates
    {
        List<DateTime> myDates = new List<DateTime>();
        
        #region constructor that adds random dates to the list. If the date cannot be added - increment count and trya again
        public VariousDates(int amount)
        {
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                try
                {
                    myDates.Add(DateTime.Parse($"{rnd.Next(2000, 2022)} - {rnd.Next(1, 13)} - {rnd.Next(1, 32)}"));

                    // myDates.Add(new DateTime(rnd.Next(2000, 2022), rnd.Next(1, 13), rnd.Next(1, 32)));   funkar också,
                    // eftersom catch kommer fånga datum som inte går att addera till listan
                    // int year = rnd.Next(2000,2022);
                    // int month = rnd.Next(1,13);
                    // int day = rnd.Next(1,32);
                    // myDate = new DateTime(year,month,day);
                }
                catch
                {
                    i--;
                }
            }
            
        }
        #endregion

        #region Tostring that writes dates every fifth row
        public override string ToString()
        {
            
            string sRet = "";
            for (int i = 0; i < myDates.Count; i++)
            {
                sRet += $"{myDates[i],-20:d}";

                if ((i+1) % 5 == 0)
                {
                    sRet += $"\n";
                }
            }
            return sRet;
        }
        #endregion

        #region counter that counts the amount of dates in a specific month
        public int Count(int month)
        {
            
            int count = 0;

            foreach (var item in myDates)
            {
                if (item.Month == month)
                    count++;
            }
            return count;
            
        }
        #endregion

        public int Count() => myDates.Count();
        public void Sort() => myDates.Sort();
    }
}
// 4. I VariousDates 
//	- Skapa en lista av DateTime
//	- Skapa en constructor som skapar ett antal element i listan med random datum
//	- Override ToString() för att skriva Datum 5 per rad
// 5. I Program skapa en instans av VariousDates och skriv ut den
// 6. Implementera Count och Sort
// 7. Skriv några kodrader i Program som testar Count och Sort
