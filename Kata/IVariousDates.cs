using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    interface IVariousDates
    {
        /// <summary>
        /// som räknar antalet skapade datum i en viss månad
        /// </summary>
        /// <returns></returns>
        public int Count(int month);
        
        /// <summary>
        /// som returnerar totala antalet datum skapade
        /// </summary>
        /// <returns></returns>
        public int Count();


        /// <summary>
        /// som sorterar datum en lista
        /// </summary>
        public void Sort();
      
    }
}
