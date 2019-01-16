using System;

namespace BubbleSortApp
{
    class Program
    {
        //Method which implements bubble sort
        public static void Bubble(int[] data)
        {
            bool newLoopNeeded = false;
            int temp;
            int loop = 0;

            while (!newLoopNeeded)
            {
                newLoopNeeded = true;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i + 1] < data[i])
                    {
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        newLoopNeeded = false;
                    }
                    loop++;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arrayOfRandomIntegers = new int[100];//Array declaration
            Random random = new Random();

            //Filling the array with random integers
            for (int i = 0; i < 100; i++)
            {
                arrayOfRandomIntegers[i] = random.Next(); 
            }

            Bubble(arrayOfRandomIntegers);//Sorting the array using bubble sort

            //Printing sorted array and closing the program
            foreach (int number in arrayOfRandomIntegers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close the screen...");
            Console.ReadKey();
        }
    }
}
