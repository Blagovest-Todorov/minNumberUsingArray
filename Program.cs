namespace _01.strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class stringMinNum
    {

        static void Main()
        {    
            //string[] towns = {"Sofia", "Varna", "Plovdiv", 
            //"Pleven", "Bourgas", "Rousse", "Yambol"};
            //string firstTown = towns[0];

            //for (int i = 0; i < towns.Length; i++)
            //{
            //    string currentTown = towns[i];
            //    if (String.Compare(currentTown, firstTown) < 0)
            //    {
            //        firstTown == currentTown;
            //    }

            //}
            //Console.WriteLine("first town: {0}", firstTown);

            int[] numbers = { 6, 2, 2, 3, 4, 0, 5, 100, 70, 250, 200,-1 };
            int minNumber = numbers[0];

            for (int i = 1; i<numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                } 
            }
            Console.WriteLine("the min number {0}", minNumber);


        }


    }
            
}
         

    
