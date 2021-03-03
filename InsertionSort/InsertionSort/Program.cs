using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 5, 4, 3, 78, 123, 6, 4, 3, 6, 8, 2, 3, 5, 9 };
            int[] newMas = Insertion(mas);
            foreach (var item in newMas)
            {
                Console.Write(" " + item);
            }

            Console.ReadLine();

        }

        public static int[] Insertion(int[] mas)
        {
            int j;
            int key;
            for (int i = 1; i < mas.Length; i++)
            {
                j = i - 1;
                key = mas[i];

                
                while(j>= 0 && mas[j] > key)
                {
                    mas[j + 1] = mas[j];
                    j -= 1; 
                }
                mas[j + 1] = key;
            }
            return mas;
        }

    }
}
