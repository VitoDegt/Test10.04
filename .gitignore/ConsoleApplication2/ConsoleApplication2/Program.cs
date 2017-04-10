using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    struct City
    {
        string Name;
        int Population;
    }
    class Program
    {
       
        
        static void Main(string[] args)
        {
            City[] cities = new City();
            string text = "Kharkiv=1431000,Kiev=280400,LasVegas=603400";
            char[] delimiterChars = { '=', ',' };
            string[] words = text.Split(delimiterChars);

            foreach (var item in words)
            {
                 
            }

            int theBiggesCity = 0;
            int longesNameCity = 0;


            for (int i = 0; i < words.Length; i++)
            {
                
            }
            

        }
    }
}
