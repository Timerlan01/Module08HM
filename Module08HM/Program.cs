using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08HM
{
    class Program
    {
        static void Main()
        {
            int size = 5; // Размер массива
            SquaringIndexer indexer = new SquaringIndexer(size);

            for (int i = 0; i < size; i++)
            {
                indexer[i] = i; // Устанавливаем значение, которое будет возводиться в квадрат
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element {i}: {indexer[i]}");
            }
        }
    }

}
